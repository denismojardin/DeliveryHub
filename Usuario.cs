namespace DeliveryHub
{
    class Usuario
    {
        private static int _contadorId = 0;
        public int Id { get; private set; }
        public string Username { get; internal set; } = " ";
        private string Password { get; set; } = " ";
        public string Email { get; internal set; } = " ";

        public Usuario(string username, string password, string email)
        {
            _contadorId++;
            Id = _contadorId;
            Username = username;
            Password = password;
            Email = email;
        }

        public bool ValidarPassword(string passwordIntento)
        {
            return Password == passwordIntento;
        }
    }
}
