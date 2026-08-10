using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto___O_Mercador_de_Arcádia
{
    internal class Pergaminho : Item
    {
        private string _TipoMagia;

        public Pergaminho() { }
        public Pergaminho(string nome, double preco, Raridade nivel, int quantidade, string tipomagia) : base(nome, preco, quantidade, nivel)
        {
            _TipoMagia = tipomagia;
        }

    }
}
