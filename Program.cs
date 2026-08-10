using Projeto___O_Mercador_de_Arcádia;

public class Program
{
    public static void Main(string[] args)
    {
        Loja loja1 = new Loja();

        int opcao;

        do
        {
            Console.WriteLine("=== MENU ===");
            Console.WriteLine("1. Cadastro\n2. Lista\n3. Vender\n4. Remover\n\n0. Sair\n");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("1. Arma\n2. Poção\n3. Pergaminho.\n");
                    int opcao1 = int.Parse(Console.ReadLine());

                    switch (opcao1)
                    {
                        case 1:
                            Console.Clear();

                            Console.WriteLine("Nome:");
                            string nome1 = Console.ReadLine();

                            Console.WriteLine("Preço:");
                            double preco1 = double.Parse(Console.ReadLine());

                            Console.WriteLine("Quantidade:");
                            int quantidade1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Dano:");
                            int dano1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Raridade?\n\n1. Comum\n2. Raro\n3. Épico\n");
                            int opcaoRaridade1 = int.Parse(Console.ReadLine());

                            Raridade nivel1 = (Raridade)(opcaoRaridade1 - 1);

                            Arma arma1 = new Arma(nome1, preco1, nivel1, quantidade1, dano1);

                            loja1.AdicionarItem(arma1);

                            Console.WriteLine("Cadastrado Com Sucesso!\n");
                            Console.WriteLine("Pressione Qualquer Tecla Para Voltar Para O Menu...\n");

                            Console.ReadKey();
                            Console.Clear();

                            break;

                        case 2:
                            Console.Clear();

                            Console.WriteLine("Nome:");
                            string nome2 = Console.ReadLine();

                            Console.WriteLine("Preço:");
                            double preco2 = double.Parse(Console.ReadLine());

                            Console.WriteLine("Quantidade:");
                            int quantidade2 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Efeito:");
                            string efeito2 = Console.ReadLine();

                            Console.WriteLine("Raridade?\n\n1. Comum\n2. Raro\n3. Épico\n");
                            int opcaoRaridade2 = int.Parse(Console.ReadLine());

                            Raridade nivel2 = (Raridade)(opcaoRaridade2 - 1);

                            Poção pocao1 = new Poção(nome2, preco2, nivel2, quantidade2, efeito2);

                            loja1.AdicionarItem(pocao1);

                            Console.WriteLine("Cadastrado Com Sucesso!\n");
                            Console.WriteLine("Pressione Qualquer Tecla Para Voltar Para O Menu...\n");

                            Console.ReadKey();
                            Console.Clear();

                            break;

                        case 3:
                            Console.Clear();

                            Console.WriteLine("Nome:");
                            string nome3 = Console.ReadLine();

                            Console.WriteLine("Preço:");
                            double preco3 = double.Parse(Console.ReadLine());

                            Console.WriteLine("Quantidade:");
                            int quantidade3 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Tipo de Magia:");
                            string magia3 = Console.ReadLine();

                            Console.WriteLine("Raridade?\n\n1. Comum\n2. Raro\n3. Épico\n");
                            int opcaoRaridade3 = int.Parse(Console.ReadLine());

                            Raridade nivel3 = (Raridade)(opcaoRaridade3 - 1);

                            Pergaminho perg1 = new Pergaminho(nome3, preco3, nivel3, quantidade3, magia3);

                            loja1.AdicionarItem(perg1);

                            Console.WriteLine("Cadastrado Com Sucesso!\n");
                            Console.WriteLine("Pressione Qualquer Tecla Para Voltar Para O Menu...\n");

                            Console.ReadKey();
                            Console.Clear();

                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Opção Inválida. Retornando Ao Menu...");
                            Console.ResetColor();

                            Console.WriteLine("\nPressione qualquer tecla para continuar...");

                            Console.ReadKey();
                            Console.Clear();
                            break;
                    } 
                    break; 

                case 2:
                    Console.Clear();

                    loja1.ListarItens();
                    Console.WriteLine("Pressione Qualquer Tecla Para Voltar Para O Menu...\n");

                    Console.ReadKey();
                    Console.Clear();

                    break;

                case 3:
                    Console.Clear();

                    loja1.ListarItens();
                    Console.WriteLine("ID:");
                    int idVenda = int.Parse(Console.ReadLine());

                    Console.WriteLine("Quantidade:");
                    int qtdVenda = int.Parse(Console.ReadLine());

                    loja1.Venda(idVenda, qtdVenda);

                    Console.WriteLine("Pressione Qualquer Tecla Para Voltar Para O Menu...\n");

                    Console.ReadKey();
                    Console.Clear();

                    break;

                case 4:
                    Console.Clear();

                    loja1.ListarItens();

                    Console.WriteLine("1. Remover Quantidade.\n2. Remover Registro.\n");
                    int opcaoRemover = int.Parse(Console.ReadLine());

                    switch (opcaoRemover)
                    {
                        case 1:
                            Console.WriteLine("ID:");
                            int idRemover1 = int.Parse(Console.ReadLine());

                            Console.Write("Deseja Remover Quantas Unidades?: ");
                            int qtdRemover = int.Parse(Console.ReadLine());

                            loja1.Baixa(idRemover1, qtdRemover);

                            break;

                        case 2:
                            Console.WriteLine("ID:");
                            int idRemover2 = int.Parse(Console.ReadLine());

                            Console.WriteLine($"Deseja Remover Completamente o Registro Desse Item?\n");
                            Console.WriteLine($"1. Sim\n2. Não\n");
                            int confirmar = int.Parse(Console.ReadLine());

                            switch (confirmar)
                            {
                                case 1:
                                    loja1.Remover(idRemover2);
                                    break;
                                case 2:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Operação Cancelada. O Item Continuará No Estoque.");
                                    Console.ResetColor();
                                    break;
                                default:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Opção Inválida. Retornando Ao Menu...");
                                    Console.ResetColor();

                                    Console.WriteLine("\nPressione qualquer tecla para continuar...");

                                    Console.ReadKey();
                                    Console.Clear(); 
                                    break;
                            }
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Opção Inválida. Retornando Ao Menu...");
                            Console.ResetColor();

                            Console.WriteLine("\nPressione qualquer tecla para continuar...");

                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }

                    Console.WriteLine("\nPressione Qualquer Tecla Para Voltar Para O Menu...\n");

                    Console.ReadKey();
                    Console.Clear();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção Inválida. Retornando Ao Menu...");
                    Console.ResetColor();

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");

                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

        
        }while (opcao != 0);

        Console.WriteLine("\nObrigado Por Usar O Sistema De Arcádia! Até a Próxima.");
    }
}

