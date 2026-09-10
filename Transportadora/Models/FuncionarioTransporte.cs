using System;
using System.Collections.Generic;
using System.Text;

namespace Transportadora.Models
{
    public abstract class FuncionarioTransporte
    {
        public string Nome { get; private set; }
        public int Registro { get; private set; }

        protected FuncionarioTransporte(string nome, int registro)
        {
            Nome = nome;
            Registro = registro;
        }

        public virtual void MostrarDetalhes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Registro: {Registro}");
        }
    }
}
