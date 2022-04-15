using System;
using System.ComponentModel.DataAnnotations;

public class BaseData
{
    //data info
    [MaxLength(2)]
    public DateTime FechaCreacion { get; set; }
    [MaxLength(2)]
    public DateTime FechaActualizacion { get; set; }
    [MaxLength(2)]
    public DateTime? FechaBorrado { get; set; }
    public bool? EstadoBorrado { get; set; }
}