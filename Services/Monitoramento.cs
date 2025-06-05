using System;
using System.Collections.Generic;

namespace GS_C_.Services
{
    public class Monitoramento
    {
        public List<string> Logs { get; private set; } = new List<string>();

        public void RegistrarAtividade(string descricao)
        {
            string log = $"[{DateTime.Now}] {descricao}";
            Logs.Add(log);
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

        public void RelatarOcorrencia(DateTime data, string descricao)
        {
            RegistrarAtividade($"Ocorrência relatada em {data:dd/MM/yyyy}: {descricao}");
        }

        public void GerarAlerta(string usuario, DateTime data)
        {
            if (usuario.ToLower() == "admin")
            {
                RegistrarAtividade($"Alerta de segurança: Acesso crítico por {usuario} em {data:dd/MM/yyyy}");
            }
        }

        public void RegistrarFalhaServico(string servico)
        {
            RegistrarAtividade($"Falha registrada no serviço: {servico}");
        }

        public void GerarRelatorioFinal()
        {
            int totalAntes = Logs.Count;
            RegistrarAtividade("==== Relatório Final Gerado ====");
            RegistrarAtividade($"Total de logs registrados: {totalAntes}");
        }
    }
}
