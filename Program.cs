using System;
using GS_C_.Services;
using GS_C_.Models;

namespace GS_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Autenticador auth = new Autenticador();
            Monitoramento monitor = new Monitoramento();

            Console.WriteLine("=== Sistema de Monitoramento Cibernético ===");
            Console.Write("Usuário: ");
            string usuario = Console.ReadLine();

            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            if (auth.Login(usuario, senha))
            {
                Console.WriteLine("Login realizado com sucesso!");
                Console.Write("Digite uma data para simular (ex: 2024-12-31): ");
                string entrada = Console.ReadLine();

                monitor.SimularErro(entrada);
                monitor.RegistrarAtividade("Atividade normal após simulação.");
            }
            else
            {
                Console.WriteLine("Usuário ou senha inválidos.");
            }

            Console.WriteLine("\n=== Logs Registrados ===");
            foreach (var log in monitor.Logs)
            {
                Console.WriteLine(log);
            }

            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
