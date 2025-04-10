class Program
{
    static void Main()
    {
        int ingressoVIP = 'x', ingressoPrioritario = 'y', ingressoComum = 'z', ingressoTotal = ingressoComum + ingressoPrioritario + ingressoVIP, opcao;

        do{
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("1. Registrar a entrada de um espectador");
            System.Console.WriteLine("2. Registrar a saída de um espectador");
            System.Console.WriteLine("3. Consultar ingressos disponíveis");
            System.Console.WriteLine("4. Exibir resumo");
            System.Console.WriteLine("5. Sair");
            System.Console.WriteLine("---------------------------------------");
            
            opcao = int.Parse(Console.ReadLine());
            
            switch(opcao){
                case 1:
                    break;
                
                case 2:
                    Console.Clear();
                    System.Console.WriteLine("---------------------------------------");
                    System.Console.Write("Digite seu nome: ");
                    Console.ReadLine();
                    System.Console.Write("Digite sua idade: ");
                    Console.ReadLine();
                    System.Console.Write("Digite o número do ingresso: ");
                    Console.ReadLine();
                    System.Console.Write("Digite o tipo do ingresso: ");
                    Console.ReadLine();
                    Console.Clear();
                    System.Console.WriteLine("Obrigado pela presença, volte sempre! :)");
                    Console.ReadLine();
                    Console.Clear();
                    
                    break;

                case 3:
                    break;
                
                case 4:
                    break;

                case 5:
                    Console.Clear();
                    System.Console.WriteLine("---------------------------------------");
                    System.Console.WriteLine("Sair[S/N]");
                    System.Console.WriteLine("---------------------------------------");
                    char sair = char.Parse(Console.ReadLine());
                    
                    if(sair == 'S' || sair == 's'){
                        Console.Clear();
                        System.Console.WriteLine("---------------------------------------");
                        System.Console.WriteLine("Saindo");
                        System.Console.WriteLine("---------------------------------------");
                    } else if(sair == 'N' || sair == 'n'){
                        Console.Clear();
                        System.Console.WriteLine("---------------------------------------");
                        System.Console.WriteLine("Voltando para o menu");
                        System.Console.WriteLine("---------------------------------------");
                        Console.ReadLine();
                        Console.Clear();
                        opcao = 0;
                    }
                    break;
                
                default:
                    Console.Clear();
                    System.Console.WriteLine("---------------------------------------");
                    System.Console.WriteLine("A opção que digitou não exite \nConfira se digitou certo");
                    System.Console.WriteLine("---------------------------------------");
                    System.Console.WriteLine("Aperte enter para voltar");
                    System.Console.WriteLine("---------------------------------------");
                    Console.ReadLine();
                    Console.Clear();

                    break;
            }
        } while(opcao != 5);
    }
}