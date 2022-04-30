using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioRapido.Model
{
    public class Auditoria: BaseData
    {
        public int Id { get; set; }
        public int UsuarioId   { get; set; }
        [MaxLength(80)]
        public string Modulo { get; set; }
        [MaxLength(200)]
        public string Operacion { get; set; }
        [MaxLength(100)]
        public string Estacion { get; set; }
        [MaxLength(100)]
        public string Observacion { get; set; }
        public virtual Usuario Usuario { get; set; }

    }
}
