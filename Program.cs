class Program
{
    static void Main()
    {
        int ingressoVIP = 20, ingressoPrioritario = 30, ingressoComum = 50, ingressoComumPresente = 0, ingressoPrioritarioPresente = 0, ingressoVIPresente = 0, opcao, quantidadePessoas = 0, idadeEntrou = 0, idadeSaiu = 0, codigoIngressoEntrou = 0, codigoIngressoSaida = 0;
        string nomeEntrou = "", tipoIngressoEntrou = "", nomeSaiu = "", tipoIngressoSaiu = "";

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
                    System.Console.Write("Digite seu nome: ");
                    nomeEntrou = Console.ReadLine();
                    System.Console.Write("Digite sua idade: ");
                    idadeEntrou = int.Parse(Console.ReadLine());
                    System.Console.Write("Digite o tipo do ingresso: ");
                    tipoIngressoEntrou = Console.ReadLine();

                    if(tipoIngressoEntrou == "Comum" || tipoIngressoEntrou == "comum"){
                        System.Console.Write("Código do ingresso [4 digitos]: ");
                        codigoIngressoEntrou = int.Parse(Console.ReadLine());
                        ingressoComum--;
                        ingressoComumPresente++;
                        quantidadePessoas++;

                    } else if(tipoIngressoEntrou == "Prioritario" || tipoIngressoEntrou == "prioritario"){
                        System.Console.Write("Código do ingresso [4 digitos]: ");
                        codigoIngressoEntrou = int.Parse(Console.ReadLine());
                        ingressoPrioritario--;
                        ingressoPrioritarioPresente++;
                        quantidadePessoas++;

                    } else if(tipoIngressoEntrou == "VIP" || tipoIngressoEntrou == "vip"){
                        System.Console.Write("Código do ingresso [4 digitos]: ");
                        codigoIngressoEntrou = int.Parse(Console.ReadLine());
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
                    Console.Clear();
                    System.Console.WriteLine("---------------------------------------");
                    System.Console.Write("Digite seu nome: ");
                    nomeSaiu = Console.ReadLine();
                    System.Console.Write("Digite sua idade: ");
                    idadeSaiu = int.Parse(Console.ReadLine());
                    System.Console.Write("Digite o tipo do ingresso: ");
                    tipoIngressoSaiu=Console.ReadLine();

                    if(tipoIngressoSaiu == "Comum" || tipoIngressoSaiu == "comum"){
                        System.Console.Write("Código do ingresso [4 digitos]: ");
                        codigoIngressoSaida = int.Parse(Console.ReadLine());
                        ingressoComum++;
                        ingressoComumPresente--;
                        quantidadePessoas--;

                    } else if(tipoIngressoSaiu == "Prioritario" || tipoIngressoSaiu == "prioritario"){
                        System.Console.Write("Código do ingresso [4 digitos]: ");
                        codigoIngressoSaida = int.Parse(Console.ReadLine());
                        ingressoPrioritario++;
                        ingressoPrioritarioPresente--;
                        quantidadePessoas--;

                    } else if(tipoIngressoSaiu == "VIP" || tipoIngressoSaiu == "vip"){
                        System.Console.Write("Código do ingresso [4 digitos]: ");
                        codigoIngressoSaida = int.Parse(Console.ReadLine());
                        ingressoVIP++;
                        ingressoVIPresente--;
                        quantidadePessoas--;

                    } else {
                        System.Console.WriteLine("Tipo de ingresso inexistente");
                    }

                    System.Console.WriteLine("Obrigado pela presença, volte sempre! :)");
                    System.Console.WriteLine("---------------------------------------");
                    Console.ReadLine();
                    Console.Clear();
                    
                    break;

                case 3:
                    Console.Clear();
                    System.Console.WriteLine("---------------------------------------");
                    System.Console.WriteLine("Restam os seguintes ingressos: ");
                    System.Console.WriteLine(ingressoComum+" Ingressos Comuns");
                    System.Console.WriteLine(ingressoPrioritario+ " Ingressos Prioritários");
                    System.Console.WriteLine(ingressoVIP+" Ingressos VIPS");
                    System.Console.WriteLine("---------------------------------------");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                
                case 4:
                    Console.Clear();
                    System.Console.WriteLine("---------------------------------------");
                    System.Console.WriteLine($"Total de pessoas presentes: {quantidadePessoas}");
                    System.Console.WriteLine("---------------------------------------");
                    System.Console.WriteLine($"Quantidade de pessoas por categoria: \nComum: {ingressoComumPresente} \nPrioritário: {ingressoPrioritarioPresente} \nVIP: {ingressoVIPresente}");
                    System.Console.WriteLine("---------------------------------------");
                    System.Console.WriteLine($"Percentual de pessoas por categoria: \nComum: {ingressoComumPresente / quantidadePessoas} \nPrioritário: {ingressoPrioritarioPresente / quantidadePessoas} \nVIP: {ingressoVIPresente / quantidadePessoas}");
                    System.Console.WriteLine("---------------------------------------");
                    System.Console.WriteLine($"Ingressos disponíveis por categoria: \nComum: {ingressoComum} \nPrioritário: {ingressoPrioritario} \nVIP: {ingressoVIP}");
                    System.Console.WriteLine("---------------------------------------");
                    System.Console.WriteLine($"Dados da última pessoa a entrar: \nNome: {nomeEntrou} \nIdade: {idadeEntrou} \nNúmero do ingresso: {codigoIngressoEntrou}");
                    System.Console.WriteLine("---------------------------------------");
                    System.Console.WriteLine($"Dados da última pessoa a sair: \nNome: {nomeSaiu} \nIdade: {idadeSaiu} \nNúmero do ingresso: {codigoIngressoSaida}");
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