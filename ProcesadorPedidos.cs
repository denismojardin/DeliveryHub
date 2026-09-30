namespace DeliveryHub
{
    class ProcesadorPedidos
    {
        private readonly IInventario _inventario;
        private readonly INotificaciones _notificador;

        public ProcesadorPedidos(IInventario inventario, INotificaciones notificador)
        {
            _inventario = inventario;
            _notificador = notificador;
        }

        public void Procesar(PedidoBasico pedido)
        {
            if (_inventario.ConteoInventario(pedido.PiezasPedidas))
            {
                pedido.Procesado = true;
                pedido.Total = pedido.CalcularTotal();
                _notificador.EnvioNotificacion("Pedido registrado por un total de $" + pedido.Total);
            }
            else
            {
                throw new InvalidOperationException("Stock insuficiente");
            }
        }
    }
}
