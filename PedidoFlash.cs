namespace DeliveryHub
{
    class PedidoFlash : PedidoBasico
    {
        protected double tarifaUrgencia = 1.3;

        public PedidoFlash(int numeroPedido, string direccionEntrega, int piezasPedidas) : base(numeroPedido, direccionEntrega, piezasPedidas)
        { 
        }

        public override double CalcularTotal()
        {
            double costoTotal = costoEnvio * tarifaUrgencia;
            return costoTotal;
        }
    }
}
