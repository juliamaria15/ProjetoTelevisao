Televisao tv = new Televisao(55f);
int opcao;

do
{
    Console.WriteLine("\n=== MENU TV ===");
    Console.WriteLine("1 - Ligar TV");
    Console.WriteLine("2 - Aumentar Volume");
    Console.WriteLine("3 - Diminuir Volume");
    Console.WriteLine("4 - Ativar/Desativar Mudo");
    Console.WriteLine("5 - Avançar Canal");
    Console.WriteLine("6 - Retroceder Canal");
    Console.WriteLine("7 - Ir para canal");
    Console.WriteLine("8 - Exibir Estado da TV");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");

    string? entrada = Console.ReadLine();
    if (!int.TryParse(entrada, out opcao))
    {
        Console.WriteLine("Opção inválida.");
        continue;
    }

    switch (opcao)
    {
        case 1:
            tv.Ligar();
            break;
        case 2:
            {
                int antes = tv.ObterVolume();
                tv.AumentarVolume();
                int depois = tv.ObterVolume();
                Console.WriteLine($"Seu volume estava em {antes} e agora está em {depois}.");
                break;
            }
        case 3:
            {
                int antes = tv.ObterVolume();
                tv.DiminuirVolume();
                int depois = tv.ObterVolume();
                Console.WriteLine($"Seu volume estava em {antes} e agora está em {depois}.");
                break;
            }
        case 4:
            tv.AtivarOuDesativarMudo();
            break;
        case 5:
            {
                int antes = tv.ObterCanal();
                tv.AvancarCanal();
                int depois = tv.ObterCanal();
                Console.WriteLine($"Seu canal era {antes} e agora é {depois}.");
                break;
            }
        case 6:
            {
                int antes = tv.ObterCanal();
                tv.RetrocederCanal();
                int depois = tv.ObterCanal();
                Console.WriteLine($"Seu canal era {antes} e agora é {depois}.");
                break;
            }
        case 7:
            Console.Write("Digite o número do canal: ");
            if (int.TryParse(Console.ReadLine(), out int canal))
            {
                int antes = tv.ObterCanal();
                tv.IrParaCanal(canal);
                int depois = tv.ObterCanal();
                Console.WriteLine($"Seu canal era {antes} e agora é {depois}.");
            }
            else
            {
                Console.WriteLine("Canal inválido.");
            }
            break;
        case 8:
            tv.ExibirEstado();
            break;
        case 0:
            Console.WriteLine("Saindo da TV...");
            tv.Desligar();
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

} while (opcao != 0);