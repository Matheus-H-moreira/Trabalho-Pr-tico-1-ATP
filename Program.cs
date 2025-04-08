class Program
{
    static void Main()
    {
        int ingressoVIP = 'x', ingressoPrioritario = 'y', ingressoComum = 'z', ingressoTotal = ingressoComum + ingressoPrioritario + ingressoVIP, controlador;

        do{
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("1. Registrar a entrada de um espectador");
            System.Console.WriteLine("2. Registrar a saída de um espectador");
            System.Console.WriteLine("3. Consultar ingressos disponíveis");
            System.Console.WriteLine("4. Exibir resumo");
            System.Console.WriteLine("5. Sair");
            System.Console.WriteLine("---------------------------------------");
            
            int opcao = int.Parse(Console.ReadLine());
            controlador = opcao;

            switch(opcao){
                case 1:
                    break;
                
                case 2:
                    break;

                case 3:
                    break;
                
                case 4:
                    break;

                case 5:
                    break;
                
                default:
                    Console.Clear();
                    System.Console.WriteLine("-----------------------------");
                    System.Console.WriteLine("A opção que digitou não exite \nConfira se digitou certo");
                    System.Console.WriteLine("-----------------------------");
                    System.Console.WriteLine("Aperte enter para voltar");
                    System.Console.WriteLine("-----------------------------");
                    Console.ReadLine();
                    Console.Clear();

                    break;
            }
        } while(controlador != 5);
    }
}