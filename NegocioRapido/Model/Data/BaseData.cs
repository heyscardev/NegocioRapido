using System;
using System.ComponentModel.DataAnnotations;

public class BaseData
{
    //data info
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaActualizacion { get; set; }
    public bool? EstadoBorrado { get; set; }
}