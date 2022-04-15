using NegocioRapido.Model.enums;
using System.ComponentModel.DataAnnotations;

namespace NegocioRapido.Model.Data
{
    public class PersonaBaseData : BaseData
    {
        public TipoIdentificacion TipoIdentificacion { get; set; }
        [MaxLength(20)]
        public string NumeroIdentficacion { get; set; }
        [MaxLength(20)]
        public string? Telefono { get; set; }
        [MaxLength(250)]
        public string? Direccion { get; set; }
        [MaxLength(250)]
        public string? Imagen { get; set; }

    }
}
