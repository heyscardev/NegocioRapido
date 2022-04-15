using NegocioRapido.Model.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioRapido.Model
{
    public class Cliente : PersonaBaseData
    {
        public int Id { get; set; }
        [MaxLength(80)]
        public string Nombre { get; set; }
        [MaxLength(80)]
        public string Apellido { get; set; }
        [MaxLength(200)]
        public string? Correo { get; set; }
  
       
        public virtual ICollection<Venta> Ventas { get; private set; } = new ObservableCollection<Venta>();
    }
}
