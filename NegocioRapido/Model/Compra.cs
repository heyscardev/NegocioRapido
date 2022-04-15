using NegocioRapido.Model.enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioRapido.Model
{
    public class Compra : BaseData
    {
        public int Id { get; set; }
        public EstadoCompra EstadoCompra { get; set; }
        public DateTime? FechaCompra {get; set; }
        public DateTime? FechaRecivido { get; set; }
        [MaxLength(200)]
        public string? Descripcion { get; set; }
       
        //relation
        public int ProveedorId { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        public virtual ICollection<CompraProducto> CompraProducto { get; private  set; } = new ObservableCollection<CompraProducto>();
    }
    
}
