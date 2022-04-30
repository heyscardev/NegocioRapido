using NegocioRapido.Model.enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioRapido.Model
{
    public class Venta : BaseData
    {
        public int Id { get; set; }
        public int NFactura { get; set; }
        public int NControl { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal ValorDolar { get; set; }
        public DateTime FechaVenta { get; set; }
        // relations
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int NombreVendedor { get; set; }
        public virtual ICollection<VentaProducto> VentaProducto { get; private set; } = new ObservableCollection<VentaProducto>();
    }
   
}
