namespace NegocioRapido.Model.enums
{
    public enum EstadoCompra
    {
        OrdenadoPagado,//PAGADO MAS NO ENTREGADO
        PagadoEntregado, // PAGADO Y ENTREGADO
        Ordenado, //ORDENADO NO PAGADO NI ENTREGADO
        EntregadoPendiente,//ENTREGADO MAS NO PAGADO
        Cancelado,//CANCELADO 
    }
}
