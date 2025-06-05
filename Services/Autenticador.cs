using System.Collections.Generic;

namespace GS_C_.Services
{
    public class Autenticador
    {
        private readonly Dictionary<string, string> usuarios = new Dictionary<string, string>()
        {
            {"admin", "1234"},
            {"user", "123"}
        };

        public bool UsuarioExiste(string usuario) => usuarios.ContainsKey(usuario);

        public bool Login(string usuario, string senha)
        {
            return usuarios.ContainsKey(usuario) && usuarios[usuario] == senha;
        }
    }
}
