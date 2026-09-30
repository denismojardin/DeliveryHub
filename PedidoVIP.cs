namespace DeliveryHub
{
    class PedidoVIP : PedidoBasico
    {
        protected double costoEmpaqueEspecial;

        public PedidoVIP(int numeroPedido, string direccionEntrega, double costoEmpaqueEspecial, int piezasPedidas) : base(numeroPedido, direccionEntrega, piezasPedidas)
        {
            this.costoEmpaqueEspecial = costoEmpaqueEspecial;
        }

        public override double CalcularTotal()
        {
            double costoTotal = costoEnvio + costoEmpaqueEspecial;
            return costoTotal;
        }
    }
}
