namespace DeliveryHub
{
    class Programa
    {
        public static void Main(string[] args)
        {
            List<Usuario> baseDatosUsuarios = new List<Usuario>
            {
                new Usuario("val", "val123", "val@gmail.com"),
                new Usuario("denis", "denis727", "denis@gmail.com")
            };

            IAutenticacionService autenticacion = new AutenticacionService(baseDatosUsuarios);

            Console.WriteLine("¿Cuentas con una cuenta creada? 1. Sí 2. No");
            string? opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("Por favor, ingresa tu usuario: ");
                string username = Console.ReadLine() ?? "";
                Console.Write("Ingresa tu contraseña: ");
                string password = Console.ReadLine() ?? "";

                try
                {
                    autenticacion.IniciarSesion(username, password);
                    Console.WriteLine("Iniciaste sesión con éxito");
                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (KeyNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (opcion == "2")
            {
                Console.Write("Crea un nombre de usuario: ");
                string username = Console.ReadLine() ?? "";
                Console.Write("Crea una contraseña: ");
                string password = Console.ReadLine() ?? "";
                Console.Write("Agrega un correo electrónico: ");
                string email = Console.ReadLine() ?? "";

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
                {
                    Console.WriteLine("Ningún campo puede quedar vacío.");
                    return;
                }

                autenticacion.CrearUsuario(username, password, email);
            }
            else
            {
                Console.WriteLine("Ingresa una opción válida");
            }
        }
    }
}
