namespace DeliveryHub
{
    class PedidoBasico
    {
        protected int numeroPedido;
        protected string direccionEntrega;
        protected double costoEnvio = 50;
        protected int piezasPedidas;

        public PedidoBasico(int numeroPedido, string direccionEntrega, int piezasPedidas)
        {
            this.numeroPedido = numeroPedido;
            this.direccionEntrega = direccionEntrega;
            this.piezasPedidas = piezasPedidas;
        }
        public int NumeroPedido
        {
            get { return numeroPedido; }

        }
        public string DireccionEntrega
        {
            get { return direccionEntrega; }
        }

        public int PiezasPedidas
        {
            get { return piezasPedidas; }
            set { piezasPedidas = value; }
        }
        public double Total { get; internal set; }

        public bool Procesado { get; internal set; }

        public virtual double CalcularTotal()
        {
            return costoEnvio;
        }
    }
}