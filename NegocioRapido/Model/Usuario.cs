
using Microsoft.EntityFrameworkCore;
using NegocioRapido.Model.Data;
using NegocioRapido.Model.enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace NegocioRapido.Model
{
    [Index(nameof(NombreUsuario), IsUnique = true)]
    public class Usuario : PersonaBaseData
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string NombreUsuario { get; set; }
        [MaxLength(100)]
        public string Contraseña { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        [MaxLength(200)]
        public string Apellido { get; set; }
        public bool status { get; set; }
        
    }
   
}
