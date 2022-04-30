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
    public class Proveedor : PersonaBaseData
    {
        public int Id { get; set; }
        
        [MaxLength(200)]
        public string? Descripcion { get; set; }
        //  relation
        public virtual ICollection<Compra> Compras { get; private set; } = new ObservableCollection<Compra>();
    }
}
