using System.Text.RegularExpressions;

namespace DesafioPratico01;

class Program
{
    static void Main()
    {
        bool continuar = true;
        while (continuar)
        {
            // Criar o menu das funções do sistema
            string menu = ("Menu de funções do sistema:\n" +
                           "1. Mensagem de boas vindas\n" +
                           "2. Nome e sobrenome\n" +
                           "3. Operações Matemáticas\n" +
                           "4. Contar caracteres\n" +
                           "5. Validar placa\n" +
                           "9. Sair");
            //rocketseat

            // Solicitar ao usuário que escolha uma função do sistema
            Console.WriteLine($"\n-------------------------------------------------" +
                $"\n|   DESAFIO FUNDAMENTOS DO C# COM A ROCKETSEAT  |" +
                $"\n-------------------------------------------------" +
                $"\nDigite uma opção do {menu}");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Diga seu nome:");
                    string nome = Console.ReadLine();
                    Console.WriteLine($"Olá, {nome}! seja muito bem vindo!!!");
                    break;
                case "2":
                    Console.WriteLine("Diga seu primeiro nome:");
                    string primeiroNome = Console.ReadLine();
                    Console.WriteLine("Diga seu primeiro sobrenome:");
                    string sobrenome = Console.ReadLine();
                    Console.WriteLine($"Seu nome completo é:{primeiroNome} {sobrenome}");
                    break;
                case "3":
                    string operacoes = ("Menu de Operações Matemáticas:\n" +
                           "1. Somar\n" +
                           "2. Subtrair\n" +
                           "3. Multiplicar\n" +
                           "4. Dividir\n");
                    Console.WriteLine($"Escolha uma opção{operacoes}");
                    int operacao = int.Parse(Console.ReadLine());
                    switch (operacao)
                    {
                        case 1:
                            Console.WriteLine("Digite o primeiro valor:");
                            double valor1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o segundo valor:");
                            double valor2 = double.Parse(Console.ReadLine());
                            double soma = OperacoesMatematicas.Somar(valor1, valor2);
                            Console.WriteLine($"O resultado da soma é: {soma}");
                            break;
                        case 2:
                            Console.WriteLine("Digite o primeiro valor:");
                            double val1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o segundo valor:");
                            double val2 = double.Parse(Console.ReadLine());
                            double subtracao = OperacoesMatematicas.Subtrair(val1, val2);
                            Console.WriteLine($"O resultado da subtração é: {subtracao}");
                            break;
                        case 3:
                            Console.WriteLine("Digite o primeiro valor:");
                            double v1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o segundo valor:");
                            double v2 = double.Parse(Console.ReadLine());
                            double multiplicacao = OperacoesMatematicas.Multiplicar(v1, v2);
                            Console.WriteLine($"O resultado da multiplicação é: {multiplicacao}");
                            break;
                        case 4:
                            Console.WriteLine("Digite o primeiro valor:");
                            double n1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o segundo valor:");
                            double n2 = double.Parse(Console.ReadLine());
                            double divisao = OperacoesMatematicas.Dividir(n1, n2);
                            Console.WriteLine($"O resultado da divisão é: {divisao}");
                            break;
                        default:
                            Console.WriteLine("Operação não reconhecida.");
                            break;
                    }

                    break;
                case "4":
                    Console.WriteLine("Digite o texto:");
                    string texto = Console.ReadLine();
                    int quantidadeCaracteres = texto.Length;
                    Console.WriteLine($"A quantidade de caracteres do texto {texto} é: {quantidadeCaracteres}");
                    break;
                case "5":
                    Console.WriteLine("Digite a placa do veículo.");
                    string placa = Console.ReadLine();

                    string placaFormatada = placa.Trim().ToUpper();
                    const string regexPlacaAntiga = @"^[A-Z]{3}-?[0-9]{4}$";
                    bool valida1 = Regex.IsMatch(placaFormatada, regexPlacaAntiga);

                    if (placaFormatada.Length == 8 && valida1)
                    {
                        Console.WriteLine($"A placa {placa} é válida no padrão antigo.");
                    }
                    else
                    {
                        Console.WriteLine($"A placa {placa} é inválida no padrão antigo (ABC-1234).");
                    }

                    break;
                case "9":
                    continuar = false;
                    Console.WriteLine("\nEncerrando o programa. Até mais!\n");
                    break;
                default:
                    Console.WriteLine("Opção não reconhecida.");
                    break;
            }

        }
    }
}
