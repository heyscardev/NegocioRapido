using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioRapido.Model
{
    public class CompraProducto : BaseData
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal Precio { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal Impuesto { get; set; }
        public int Cantidad { get; set; }
        // relations
        public int CompraId { get; set; }
        public virtual Compra Compra { get; set; }
        public int ProductoId { get; set; }
        public virtual Producto Producto { get; set; }

    }
}
