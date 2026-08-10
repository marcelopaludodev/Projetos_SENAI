using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto___O_Mercador_de_Arcádia
{
    internal class Loja
    {
        private List<Item> estoque = new List<Item>();

        public void AdicionarItem(Item novoItem)
        {
            estoque.Add(novoItem);
            Console.WriteLine($"{novoItem.GetNome()} Adicionado Ao Estoque!\n");
        }

        public void ListarItens()
        {
            Console.WriteLine("=== ESTOQUE ===");

            if (estoque.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("O Estoque Está Vazio!");

                Console.ResetColor();
            }
            else
            {
                foreach (Item i in estoque)
                {
                    if (i.GetNivel() == Raridade.Épico)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }

                    Console.WriteLine(i.ToString());

                    Console.ResetColor();
                }

            }
        }

        public void Venda(int id, int quantidade)
        {
            foreach(Item i in estoque)
            {
                if (i.GetID() == id)
                {
                    if (i.GetQuantidade() >= quantidade)
                    {
                        i.SetQuantidade(i.GetQuantidade() - quantidade);
                        Console.WriteLine($"Sucesso! Venda Efetuada.\n");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Erro: Você não tem estoque suficiente!");

                        Console.ResetColor();
                    }
                    return;
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Erro: ID não encontrado.");

            Console.ResetColor();

        }

        public void Baixa(int id, int quantidadeParaRemover)
        {
            foreach (Item i in estoque)
            {
                if (i.GetID() == id)
                {
                    if (i.GetQuantidade() >= quantidadeParaRemover)
                    {
                        i.SetQuantidade(i.GetQuantidade() - quantidadeParaRemover);

                        Console.WriteLine($"Baixa efetuada!\n");
                        Console.WriteLine($"Estoque atual: {i.GetQuantidade()}");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine($"Erro: O Estoque Atual De '{i.GetNome()}' é De Apenas {i.GetQuantidade()}!");

                        Console.ResetColor();
                    }
                    return;
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Erro: Não foi possível encontrar um item com o ID informado!");

            Console.ResetColor();
        }

        public void Remover(int id)
        {
            int removido = estoque.RemoveAll(i => i.GetID() == id);

            if(removido > 0)
            {
                Console.WriteLine("Registro Do Item Removido Com Sucesso Do Estoque!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Erro: Não Foi Possível Encontrar Um Item Com Esse ID.");

                Console.ResetColor();
            }
        }
    }
}
