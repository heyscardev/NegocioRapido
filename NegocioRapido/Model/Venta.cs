using NegocioRapido.Model.enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioRapido.Model
{
    public class Venta : BaseData
    {
        public int Id { get; set; }
        public EstadoVenta EstadoVenta { get; set; }
        // relations
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int NombreVendedor { get; set; }
        public virtual ICollection<VentaProducto> VentaProducto { get; private set; } = new ObservableCollection<VentaProducto>();
    }
   
}
