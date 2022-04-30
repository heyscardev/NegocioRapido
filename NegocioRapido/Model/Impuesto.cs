using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioRapido.Model
{
    public class Impuesto
    {
        public int Id { get; set; }
        public decimal Valor { get; set; } 
        public string Descripcion { get; set; }
    }
}
