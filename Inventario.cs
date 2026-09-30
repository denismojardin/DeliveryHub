namespace DeliveryHub
{
    class Inventario : IInventario
    {
       protected int piezasDisponibles;
        
      public Inventario(int piezasDisponibles)
        {
            this.piezasDisponibles = piezasDisponibles;
        }

       public int PiezasDisponibles
        {
            get { return piezasDisponibles; }
        }

       public bool ConteoInventario(int piezasPedidas)
        {
            if(piezasDisponibles >= piezasPedidas)
            {
                piezasDisponibles -= piezasPedidas;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
