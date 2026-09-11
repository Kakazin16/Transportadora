using System;

namespace Transportadora.Models
{
    public class MotoristaCarreta : FuncionarioTransporte
    {
        public string PlacaVeiculo { get; private set; }
        public string CategoriaCNH { get; private set; }

        public MotoristaCarreta(
            string nome,
            int registro,
            string placaVeiculo,
            string categoriaCNH
        ) : base(nome, registro)
        {
            PlacaVeiculo = placaVeiculo;
            CategoriaCNH = categoriaCNH;
        }

        public override void MostrarDetalhes()
        {
            Console.WriteLine("=== MOTORISTA DE CARRETA ===");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Registro: {Registro}");
            Console.WriteLine($"Placa do Veículo: {PlacaVeiculo}");
            Console.WriteLine($"Categoria da CNH: {CategoriaCNH}");
        }
    }
}