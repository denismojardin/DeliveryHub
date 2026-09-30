namespace DeliveryHub
{
    class NotificacionWhatsApp : INotificaciones
    {
        public void EnvioNotificacion(string notificacion)
        {
            Console.WriteLine("[WHATSAPP EMPRESA]: " + notificacion);
        }
    }
}
