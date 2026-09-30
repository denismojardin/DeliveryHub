namespace DeliveryHub
{
    interface IAutenticacionService
    {
        public Usuario IniciarSesion(string username, string password);
        public void CrearUsuario(string username, string password, string email);
    }
}
