using System;
using GS_C_.Services;

namespace GS_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Autenticador auth = new Autenticador();

            bool continuar = true;

            while (continuar)
            {
                Monitoramento monitor = new Monitoramento();

                Console.WriteLine("=== Sistema de Monitoramento Cibernético ===");

                bool autenticado = false;
                string usuario = "";
                while (!autenticado)
                {
                    Console.Write("Usuário: ");
                    usuario = Console.ReadLine();

                    Console.Write("Senha: ");
                    string senha = Console.ReadLine();

                    if (!auth.UsuarioExiste(usuario))
                    {
                        Console.WriteLine("Usuário não encontrado. Tente novamente.\n");
                    }
                    else if (!auth.Login(usuario, senha))
                    {
                        Console.WriteLine("Senha incorreta. Tente novamente.\n");
                    }
                    else
                    {
                        autenticado = true;
                        Console.WriteLine("\nLogin realizado com sucesso!");
                    }
                }

                Console.Write("Digite uma data para simular (ex: 2024-12-31): ");
                string entradaData = Console.ReadLine();
                monitor.SimularErro(entradaData);

                if (DateTime.TryParse(entradaData, out DateTime dataConvertida))
                {
                    Console.Write("Relate o ocorrido nesta data: ");
                    string descricaoOcorrencia = Console.ReadLine();

                    monitor.RelatarOcorrencia(dataConvertida, descricaoOcorrencia);
                    monitor.GerarAlerta(usuario, dataConvertida);

                    string resposta;
                    do
                    {
                        Console.Write("Houve falha em algum serviço? (ex: Banco de Dados, DNS) (responda s para sim ou n para nao): ");
                        resposta = Console.ReadLine()?.Trim().ToLower();
                    } while (resposta != "s" && resposta != "n");

                    if (resposta == "s")
                    {
                        Console.Write("Em qual serviço houve falha? ");
                        string servico = Console.ReadLine();
                        monitor.RegistrarFalhaServico(servico);
                    }

                    string[] palavrasCriticas = { "falha", "queda", "apagão", "erro", "pane", "energia caiu" };
                    bool atividadeNormal = true;

                    foreach (var palavra in palavrasCriticas)
                    {
                        if (descricaoOcorrencia.ToLower().Contains(palavra))
                        {
                            atividadeNormal = false;
                            break;
                        }
                    }

                    if (atividadeNormal)
                    {
                        monitor.RegistrarAtividade("Atividade normal após simulação.");
                    }
                    else
                    {
                        monitor.RegistrarAtividade("Atividade anormal detectada após simulação.");
                    }
                }
                else
                {
                    monitor.RegistrarAtividade("Data inválida inserida. Pulos de funcionalidades dependentes de data.");
                }

                monitor.GerarRelatorioFinal();

                Console.WriteLine("\n=== Logs Registrados ===");
                foreach (var log in monitor.Logs)
                {
                    Console.WriteLine(log);
                }

                // Pergunta se o usuário deseja repetir
                string respostaFinal;
                do
                {
                    Console.Write("\nDeseja realizar outro registro? (digite s para sim ou n para nao): ");
                    respostaFinal = Console.ReadLine()?.Trim().ToLower();
                } while (respostaFinal != "s" && respostaFinal != "n");

                continuar = respostaFinal == "s";
                Console.Clear(); // Limpa a tela para uma nova execução
            }

            Console.WriteLine("Encerrando o programa. Obrigado!");
        }
    }
}

