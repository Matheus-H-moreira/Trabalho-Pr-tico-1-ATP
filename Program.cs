class Program
{
    static void Main()
    {
        int ingressoVIP = 20, ingressoPrioritario = 30, ingressoComum = 50, ingressoComumPresente = 0, ingressoPrioritarioPresente = 0, ingressoVIPresente = 0, opcao, quantidadePessoas = 0, idadeEntrou = 0;
        string nomeEntrou = "", tipoIngressoEntrou = "";

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
                    nomeEntrou = Console.ReadLine();
                    System.Console.Write("Qual sua idade: ");
                    idadeEntrou = int.Parse(Console.ReadLine());
                    System.Console.Write("Qual o tipo do ingresso: ");
                    tipoIngressoEntrou = Console.ReadLine();

                    if(tipoIngressoEntrou == "Comum" || tipoIngressoEntrou == "comum"){
                        System.Console.Write("Código do ingresso [4 digitos]: ");
                        int codigoIngressoEntrou = int.Parse(Console.ReadLine());
                        ingressoComum--;
                        ingressoComumPresente++;
                        quantidadePessoas++;

                    } else if(tipoIngressoEntrou == "Prioritario" || tipoIngressoEntrou == "prioritario"){
                        System.Console.Write("Código do ingresso [4 digitos]: ");
                        int codigoIngressoEntrou = int.Parse(Console.ReadLine());
                        ingressoPrioritario--;
                        ingressoPrioritarioPresente++;
                        quantidadePessoas++;

                    } else if(tipoIngressoEntrou == "VIP" || tipoIngressoEntrou == "vip"){
                        System.Console.Write("Código do ingresso [4 digitos]: ");
                        int codigoIngressoEntrou = int.Parse(Console.ReadLine());
                        ingressoVIP--;
                        ingressoVIPresente++;
                        quantidadePessoas++;

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
                    System.Console.WriteLine("---------------------------------------");
                    System.Console.WriteLine($"Total de pessoas presentes: {quantidadePessoas}");
                    System.Console.WriteLine("---------------------------------------");
                    System.Console.WriteLine($"Quantidade de pessoas por categoria: \nComum: {ingressoComumPresente} \nPrioritário: {ingressoPrioritarioPresente} \nVIP: {ingressoVIPresente}");
                    System.Console.WriteLine("---------------------------------------");
                    System.Console.WriteLine($"Percentual de pessoas por categoria: \nComum: {ingressoComumPresente / quantidadePessoas} \nPrioritário: {ingressoPrioritarioPresente / quantidadePessoas} \nVIP: {ingressoVIPresente / quantidadePessoas}");
                    System.Console.WriteLine("---------------------------------------");
                    System.Console.WriteLine($"Ingressos disponíveis por categoria: \nComum: {ingressoComum} \nPrioritário: {ingressoPrioritario} \nVIP: {ingressoVIP}");
                    System.Console.WriteLine("---------------------------------------");
                    System.Console.WriteLine($"Dados da última pessoa a entrar: \nNome: {nomeEntrou} \nIdade: {idadeEntrou} \nNúmero do ingresso: {tipoIngressoEntrou}");
                    System.Console.WriteLine("---------------------------------------");
                    System.Console.WriteLine("Aperte enter para voltar ao menu");
                    Console.ReadLine();
                    Console.Clear();

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