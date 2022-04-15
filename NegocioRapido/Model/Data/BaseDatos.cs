using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NegocioRapido.Model.enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NegocioRapido.Model.Data
{
    public class BaseDatos : DbContext
    {
        //SETEAR LAS TABLAS ENTIDADES EN LA BASE DE DATOS
        
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<CompraProducto> CompraProductos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<VentaProducto> VentaProductos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Producto>(entity =>
            {
                //añadiendo valores por defecto a columnas de product
                entity.Property(p => p.AplicarIva)
                .HasDefaultValue(true);
                entity.Property(p => p.Inventario)
                .HasDefaultValue(0);
            });
           
            builder.Entity<Venta>(entity =>
            {
                entity.Property(p => p.EstadoVenta)
                .HasDefaultValue(EstadoVenta.Pendiente);
            });
            builder.Entity<Usuario>(entity =>
            {
                entity.Property(p => p.TipoUsuario)
                .HasDefaultValue(TipoUsuario.Vendedor);
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var CONFIGURATION = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("Configuraciones.json").Build();
                optionsBuilder
                    .UseLazyLoadingProxies()
                    .UseMySql(CONFIGURATION["ConnectionsStrings:DefaultConnection"], new MariaDbServerVersion(new Version()))
                    .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors();
            }
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            OnBeforeSaving();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }
        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
        CancellationToken cancellationToken = default(CancellationToken))
        {
            OnBeforeSaving();
            return (await base.SaveChangesAsync(acceptAllChangesOnSuccess,
                          cancellationToken));
        }
        private void OnBeforeSaving()
        {
            var entries = ChangeTracker.Entries();
            var utcNow = DateTime.UtcNow;

            foreach (var entry in entries)
            {
                if (entry.Entity is BaseData trackable)
                {
                    switch (entry.State)
                    {
                        case EntityState.Modified:
                            trackable.FechaActualizacion = utcNow;
                            entry.Property("CreatedAt").IsModified = false;
                            break;

                        case EntityState.Added:
                            trackable.FechaCreacion = utcNow;
                            trackable.FechaActualizacion = utcNow;
                            break;
                    }
                }
            }
        }
    }
}
