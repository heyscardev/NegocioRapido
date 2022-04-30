using Microsoft.EntityFrameworkCore;
using NegocioRapido.Model.enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NegocioRapido.Model.Data
{
    [Index("NumeroIdentificacion", IsUnique = true)]
    public class PersonaBaseData : BaseData
    {
        public TipoIdentificacion TipoIdentificacion { get; set; }
        [MaxLength(20)]
        
        public string NumeroIdentificacion { get; set; }
        [MaxLength(80)]
       
        public string RazonSocial { get; set; }
        [MaxLength(200)]
        public string? Correo { get; set; }
        [MaxLength(20)]
        public string? Telefono { get; set; }
        [MaxLength(250)]
        public string? Direccion { get; set; }
        [MaxLength(250)]
        public string? Imagen { get; set; }

    }
}
