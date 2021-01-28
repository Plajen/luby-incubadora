using System;
using System.Collections.Generic;

namespace lubyincubadora
{
    class MainFunc // Função Main, executada ao abrir o programa
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Olá! Digite o número de um exercício para corrigi-lo (ex: 1.1) ou SAIR para sair: ");
                string exercicio = Console.ReadLine();
                switch (exercicio)
                {
                    case "1.1":
                        {
                            lubyincubadora.Exercicio11 e11 = new lubyincubadora.Exercicio11();
                            Console.WriteLine("Digite um número inteiro para calcular seu fatorial: ");
                            int num = int.Parse(Console.ReadLine());
                            Console.WriteLine("O fatorial de {0} é: {1}.\n\n", num, e11.CalcularFatorial(num));
                            break;
                        }
                    case "1.2":
                        {
                            lubyincubadora.Exercicio12 e12 = new lubyincubadora.Exercicio12();
                            Console.WriteLine("Digite o valor-base do prêmio: ");
                            double premio = double.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o tipo do prêmio (basic, vip, premium ou special): ");
                            string tipo = Console.ReadLine();
                            Console.WriteLine("Digite o multiplicador próprio do prêmio (ex: 1.2) ou null caso não haja: ");
                            var entrada = Console.ReadLine();
                            double multiplicador;
                            if (double.TryParse(entrada, out multiplicador))
                            {
                                Console.WriteLine("O valor final do prêmio é de: {0}.\n\n", e12.CalcularPremio(premio, tipo, multiplicador));
                            }
                            else
                            {
                                Console.WriteLine("O valor final do prêmio é de: {0}.\n\n", e12.CalcularPremio(premio, tipo, null));
                            }
                            break;
                        }
                    case "1.3":
                        {
                            lubyincubadora.Exercicio13 e13 = new lubyincubadora.Exercicio13();
                            Console.WriteLine("Digite um número inteiro para descobrir quantos números primos há entre 0 e o número digitado: ");
                            int num = int.Parse(Console.ReadLine());
                            Console.WriteLine("Há {0} números primos entre 0 e {1}.\n\n", e13.ContarNumerosPrimos(num),num);
                            break;
                        }
                    case "1.4":
                        {
                            lubyincubadora.Exercicio14 e14 = new lubyincubadora.Exercicio14();
                            Console.WriteLine("Digite uma palavra ou frase sem acentos ou caracteres especiais para calcular quantas vogais há nela: ");
                            string frase = Console.ReadLine();
                            Console.WriteLine("Há {0} vogais em '{1}'.\n\n", e14.CalcularVogais(frase),frase);
                            break;
                        }
                    case "1.5":
                        {
                            lubyincubadora.Exercicio15 e15 = new lubyincubadora.Exercicio15();
                            Console.WriteLine("Digite um valor em reais (ex: R$ 1.000,00 - importante incluir os centavos): ");
                            string valor = Console.ReadLine();
                            Console.WriteLine("Digite uma porcentagem de desconto (ex: 50%) para aplicar sobre o valor: ");
                            string desconto = Console.ReadLine();
                            Console.WriteLine("O valor final obtido com o desconto é igual a {0}.\n\n", e15.CalcularValorComDescontoFormatado(valor, desconto));
                            break;
                        }
                    case "1.6":
                        {
                            lubyincubadora.Exercicio16 e16 = new lubyincubadora.Exercicio16();
                            Console.WriteLine("Digite uma data inicial no formato ddMMyyyy (ex: em vez de 28/01/2021, digite 28012021): ");
                            string data1 = Console.ReadLine();
                            Console.WriteLine("Digite a segunda data, no mesmo formato, para calcular quantos dias há de diferença entre as duas: ");
                            string data2 = Console.ReadLine();
                            Console.WriteLine("A diferença entre as duas datas é de {0} dias.\n\n",e16.CalcularDiferencaData(data1, data2));
                            break;
                        }
                    case "1.7":
                        {
                            lubyincubadora.Exercicio17 e17 = new lubyincubadora.Exercicio17();
                            Console.WriteLine("Digite quantos números inteiros positivos quiser, separados por vírgula, e aperte Enter para descobrir quais são pares: ");
                            string numeros = Console.ReadLine();
                            string[] numeros_separados = numeros.Split(",");
                            List<int> nums = new List<int>();
                            int n;
                            foreach (string s in numeros_separados)
                            {
                                if (Int32.TryParse(s, out n))
                                    nums.Add(n);
                            }
                            int[] vetor = new int[nums.Count];
                            nums.CopyTo(vetor);
                            Console.WriteLine("Os números pares dentre os que você digitou são: ");
                            foreach (int valor in e17.ObterElementosPares(vetor))
                            {
                                Console.WriteLine(valor);
                            }
                            Console.WriteLine("\n\n");
                            break;
                        }
                    case "1.8":
                        {
                            lubyincubadora.Exercicio18 e18 = new lubyincubadora.Exercicio18();
                            Console.WriteLine("Digite quantos nomes + sobrenomes (ex: Carlos Silva) quiser, separados por vírgula: ");
                            string nomes = Console.ReadLine();
                            string[] nomes_separados = nomes.Split(",");
                            Console.WriteLine("Agora digite um nome ou sobrenome que deseja procurar na lista de pessoas criada: ");
                            string nome = Console.ReadLine();
                            Console.WriteLine("Foram encontradas as seguintes pessoas: ");
                            foreach (string pessoa in e18.BuscarPessoa(nomes_separados,nome))
                            {
                                Console.WriteLine(pessoa);
                            }
                            Console.WriteLine("\n\n");
                            break;
                        }
                    case "1.9":
                        {
                            lubyincubadora.Exercicio19 e19 = new lubyincubadora.Exercicio19();
                            Console.WriteLine("Digite uma quantidade par de números separados por vírgula (ex: 1,2,3,4,5,6): ");
                            string numeros = Console.ReadLine();
                            Console.WriteLine("A matriz formada possui os seguintes pares de números: ");
                            foreach (int[] vetor in e19.TransformarEmMatriz(numeros))
                            {
                                foreach (int num in vetor)
                                {
                                    Console.Write(num);
                                }
                                Console.Write("\n");
                            }
                            Console.Write("\n\n");
                            break;
                        }
                    case "1.10":
                        {
                            lubyincubadora.Exercicio110 e110 = new lubyincubadora.Exercicio110();
                            Console.WriteLine("Digite quantos números inteiros positivos quiser, separados por vírgula, e então aperte Enter: ");
                            string numeros1 = Console.ReadLine();
                            string[] numeros_separados1 = numeros1.Split(",");
                            List<int> nums1 = new List<int>();
                            int n1;
                            foreach (string s in numeros_separados1)
                            {
                                if (Int32.TryParse(s, out n1))
                                    nums1.Add(n1);
                            }
                            int[] vetor1 = new int[nums1.Count];
                            nums1.CopyTo(vetor1);
                            Console.WriteLine("Digite outra sequência similar, também com vírgulas, e aperte Enter para comparar as duas sequências: ");
                            string numeros2 = Console.ReadLine();
                            string[] numeros_separados2 = numeros2.Split(",");
                            List<int> nums2 = new List<int>();
                            int n2;
                            foreach (string s in numeros_separados2)
                            {
                                if (Int32.TryParse(s, out n2))
                                    nums2.Add(n2);
                            }
                            int[] vetor2 = new int[nums2.Count];
                            nums2.CopyTo(vetor2);
                            Console.WriteLine("Os elementos diferenciais (que uma sequência possui e a outra não) são os seguintes: ");
                            foreach (int num in e110.ObterElementosFaltantes(vetor1, vetor2))
                            {
                                Console.WriteLine(num);
                            }
                            Console.Write("\n\n");
                            break;
                        }
                    case "SAIR":
                        {
                            System.Environment.Exit(0);
                            break;
                        }
                }
            }
        }
    }
}
