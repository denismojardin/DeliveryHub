namespace DeliveryHub
{
    class NotificacionCorreo : INotificaciones
    {
        public void EnvioNotificacion(string notificacion)
        {
            Console.WriteLine("[correo@empresa.com]: " + notificacion);
        }
    }
}
