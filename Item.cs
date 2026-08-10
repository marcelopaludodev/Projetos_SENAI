using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto___O_Mercador_de_Arcádia
{
    public enum Raridade
    {
        Comum,
        Raro,
        Épico
    }

    internal class Item
    {
        private static int _contadorID = 0;
        private int _ID;

        protected string _Nome;
        protected double _Preco;
        protected int _Quantidade;

        protected Raridade _Nivel;

        public Item() { }
        public Item(string nome, double preco, int quantidade, Raridade nivel)
        {
            _Nome = nome;
            _Preco = preco;
            _Quantidade = quantidade;
            _Nivel = nivel;

            ConfigurarID();
        }

        public int GetID() { return _ID; }

        public string GetNome() { return _Nome; }
        public void SetNome(string nome) {  _Nome = nome; }

        public double GetPreco() {  return _Preco; }
        public void SetPreco(double preco) 
        {
            if (preco <= 0)
            {
                Console.WriteLine("Erro: Valor Menor ou Igual a Zero!\n");
            }
            else
            {
                _Preco = preco;
            }
        }

        public int GetQuantidade() { return _Quantidade; }
        public void SetQuantidade(int quantidade) 
        {
            if (quantidade < 0)
            {
                Console.WriteLine("Erro: Valor Menor ou Igual a Zero!\n");
            }
            else
            {
                _Quantidade = quantidade; 
            }
        }

        public Raridade GetNivel() { return _Nivel; }
        public void SetNivel(Raridade nivel) {  _Nivel = nivel; }

        private void ConfigurarID()
        {
            _contadorID++;
            _ID = _contadorID;
        }
        public override string ToString()
        {
            return $"ID: {GetID()} | Nome: {GetNome()}\n" +
                   $"Raridade: {GetNivel()}\n" +
                   $"Preço: {CalcularPrecoFinal():C2}\n" +
                   $"Qtd: {GetQuantidade()}\n";
        }

        public virtual double CalcularPrecoFinal()
        {
            return _Preco;
        }
    }
}
