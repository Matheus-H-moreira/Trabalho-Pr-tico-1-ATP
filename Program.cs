class Program
{
    static void Main()
    {
        int ingressoVIP = 20, ingressoPrioritario = 30, ingressoComum = 50, opcao;

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
                    Console.Clear();
                    System.Console.WriteLine("---------------------------------------");
                    System.Console.Write("Qual seu nome: ");
                    string nome = Console.ReadLine();
                    System.Console.Write("Qual sua idade: ");
                    int idade = int.Parse(Console.ReadLine());
                    System.Console.Write("Qual o tipo do ingresso: ");
                    string tipoIngresso = Console.ReadLine();

                    if(tipoIngresso == "Comum" || tipoIngresso == "comum"){
                        System.Console.Write("Código do ingresso [4 digitos]: ");
                        int codigoIngresso = int.Parse(Console.ReadLine());
                        ingressoComum--;

                    } else if(tipoIngresso == "Prioritario" || tipoIngresso == "prioritario"){
                        System.Console.Write("Código do ingresso [4 digitos]: ");
                        int codigoIngresso = int.Parse(Console.ReadLine());
                        ingressoPrioritario--;

                    } else if(tipoIngresso == "VIP" || tipoIngresso == "vip"){
                        System.Console.Write("Código do ingresso [4 digitos]: ");
                        int codigoIngresso = int.Parse(Console.ReadLine());
                        ingressoVIP--;

                    } else {
                        System.Console.WriteLine("Tipo de ingresso inexistente");
                    }
                    System.Console.WriteLine("Seja bem-vindo! ");
                    System.Console.WriteLine("---------------------------------------");
                    Console.ReadLine();
                    Console.Clear();

                    break;
                
                case 2:
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