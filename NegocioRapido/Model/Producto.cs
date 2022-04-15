using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioRapido.Model
{
    public class Producto: BaseData
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        [MaxLength(50)]
        public string CodBarras { get; set; }
        [Column(TypeName ="decimal(12,2)")]
        public decimal Precio { get; set; }
        public bool AplicarIva { get; set; }
        [MaxLength(200)]
        public string? Descripcion { get; set; }
        [MaxLength(250)]
        public string? Imagen { get; set; }
        public int Inventario { get; set; }
        public int? AlertaInventario { get; set; }
        
        //relations
        public virtual ICollection<Proveedor> Proveedores { get; private set; } = new ObservableCollection<Proveedor>();
        public virtual ICollection<CompraProducto> ComprasProductos { get; private set; } = new ObservableCollection<CompraProducto>();
        public virtual ICollection<VentaProducto> VentasProductos { get; private set; } = new ObservableCollection<VentaProducto>();
    }
}
