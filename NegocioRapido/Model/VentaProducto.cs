using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioRapido.Model
{
    public class VentaProducto : BaseData
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal Precio { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal Impuesto { get; set; }
        public int Cantidad { get; set; }
        // relations
        public int ProductoId { get; set; }
        public virtual Producto Producto { get; set; }
        public int VentaId { get; set; }
        public virtual Venta Venta { get; set; }
    }
}
