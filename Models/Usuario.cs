namespace GS_C_.Models
{
    public class Usuario
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public Usuario(string nome, string email)
        {
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Nome e e-mail não podem estar vazios.");

            Nome = nome;
            Email = email;
        }
    }
}
