using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto___O_Mercador_de_Arcádia
{
    internal class Poção : Item
    {
        private string _Efeito;

        public Poção() { }
        public Poção(string nome, double preco, Raridade nivel, int quantidade, string efeito) : base(nome, preco, quantidade, nivel)
        {
            _Efeito = efeito;
        }
        public override double CalcularPrecoFinal()
        {
            return _Preco - (_Preco * 0.10);
        }

    }
}
