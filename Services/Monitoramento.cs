using System;
using System.Collections.Generic;

namespace GS_C_.Services
{
    public class Monitoramento
    {
        public List<string> Logs { get; private set; } = new List<string>();

        public void RegistrarAtividade(string descricao)
        {
            Logs.Add($"[{DateTime.Now}] {descricao}");
        }

        public void SimularErro(string input)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(input))
                    throw new ArgumentNullException("Input inválido: campo vazio.");

                if (!DateTime.TryParse(input, out DateTime data))
                    throw new FormatException("Input inválido: data incorreta.");

                RegistrarAtividade($"Data processada com sucesso: {data.ToShortDateString()}");
            }
            catch (Exception ex)
            {
                RegistrarAtividade($"Erro capturado: {ex.Message}");
            }
        }
    }
}