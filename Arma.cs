using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto___O_Mercador_de_Arcádia
{
    internal class Arma : Item
    {
        private int _Dano;

        public Arma() { }
        public Arma(string nome, double preco, Raridade nivel, int quantidade, int dano) : base(nome, preco, quantidade, nivel)
        {
            _Dano = dano;
        }

        public override double CalcularPrecoFinal()
        {
            return _Preco + (_Preco * 0.05);
        }
    }
}
