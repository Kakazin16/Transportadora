using System;

namespace Transportadora.Models
{
    public class EntregadorMoto : FuncionarioTransporte
    {
        public string PlacaVeiculo { get; private set; }
        public bool PossuiBau { get; private set; }

        public EntregadorMoto(
            string nome,
            int registro,
            string placaVeiculo,
            bool possuiBau
        ) : base(nome, registro)
        {
            PlacaVeiculo = placaVeiculo;
            PossuiBau = possuiBau;
        }

        public override void MostrarDetalhes()
        {
            Console.WriteLine("=== ENTREGADOR DE MOTO ===");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Registro: {Registro}");
            Console.WriteLine($"Placa do Veículo: {PlacaVeiculo}");
            Console.WriteLine($"Possui Baú: {(PossuiBau ? "Sim" : "Não")}");
        }
    }
}