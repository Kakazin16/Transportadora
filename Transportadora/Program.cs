using System;
using System.Collections.Generic;
using Transportadora.Models;

namespace Transportadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("   SISTEMA DE LOGÍSTICA - TRANSPORTADORA");
            Console.WriteLine("========================================\n");

            // Criando a lista genérica da classe base contendo os objetos derivados
            List<FuncionarioTransporte> funcionarios = new List<FuncionarioTransporte>
            {
                new MotoristaCarreta("Carlos Eduardo", 1001, "ABC-1234", "E"),
                new EntregadorMoto("Lucas Alves", 1002, "XYZ-9876", true)
            };

            // Executando chamadas polimórficas
            foreach (var funcionario in funcionarios)
            {
                funcionario.MostrarDetalhes();
                Console.WriteLine(); // Linha em branco para separar
            }
        }
    }
}