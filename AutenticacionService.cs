namespace DeliveryHub
{
    class AutenticacionService : IAutenticacionService
    {
        private readonly List<Usuario> listaDeUsuarios;

        public AutenticacionService(List<Usuario>? usuarios = null)
        {
            listaDeUsuarios = usuarios ?? new List<Usuario>();
        }

        public Usuario IniciarSesion(string username, string password)
        {
            foreach (Usuario usuario in listaDeUsuarios)
            {
                if (username == usuario.Username)
                {
                    if (usuario.ValidarPassword(password))
                    {
                        return usuario;
                    }
                    else
                    {
                        throw new UnauthorizedAccessException("La contraseña ingresada es incorrecta.");
                    }
                }
            }
            throw new KeyNotFoundException($"El usuario '{username}' no se encuentra registrado.");
        }

        public void CrearUsuario(string username, string password, string email)
        {
            foreach (Usuario usuario in listaDeUsuarios)
            {
                if(username == usuario.Username)
                {
                    Console.WriteLine("Este usuario ya existe");
                    return;
                }
            }
            listaDeUsuarios.Add(new Usuario(username, password, email));
        }

    }
}
