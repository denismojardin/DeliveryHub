namespace DeliveryHub
{
    interface IInventario
    {
        int PiezasDisponibles {  get; }

        bool ConteoInventario(int piezasPedidas);
    }
}
