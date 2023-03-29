using System;
using System.Linq;

namespace Atividade09_Strings.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            
            while (true)
            {
                Console.Clear();

                Console.WriteLine("(1)Exercício01 - Title Case");
                Console.WriteLine("(2)Exercício02 - Número de Palavras na Frase");
                Console.WriteLine("(3)Exercício03 - Cifra de César");
                Console.WriteLine("(4)Exercício04 - Maior Produto");
                Console.WriteLine("(5)Exercício05 - Manipulando Strings");
                Console.WriteLine("(6)Exercício06 - Lista de Municípios");

                PulaLinha();

                Console.Write("Escolha qual exercício deseja acessar: ");

                int escolhaExercicio = ValidarNumero();

                switch (escolhaExercicio)
                {
                    case 1: Exercicio01(ref continuar); break;
                    case 2: Exercicio02(ref continuar); break;
                    case 3: Exercicio03(ref continuar); break;
                    case 4: Exercicio04(ref continuar); break;
                    case 5: Exercicio05(ref continuar); break;
                    case 6: Exercicio06(ref continuar); break;
                    default:
                        break;
                }
            }
        }

        private static void Exercicio01(ref bool continuar)
        {
            do
            {
                Console.Clear();

                Console.Write("Digite uma frase para tranformá-la em Título: ");

                string frase = Console.ReadLine();

                string[] fraseArray = frase.Split(" ");

                for (int i = 0; i < fraseArray.Length; i++)
                {
                    if (!String.IsNullOrEmpty(fraseArray[i]))
                        fraseArray[i] = fraseArray[i].Substring(0, 1).ToUpper() + fraseArray[i].Substring(1);
                }

                Console.WriteLine(string.Join(" ", fraseArray));

                continuar = VoltarParaOMenu();

            } while (continuar);
        }

        private static void Exercicio02(ref bool continuar)
        {
            do
            {
                Console.Clear();

                Console.Write("Digite uma frase para contar a quantidade de palavras nela: ");

                string frase = Console.ReadLine();

                string[] fraseArray = frase.Split(" ");

                Console.WriteLine("Há {0} palavra{1} {2}", fraseArray.Length, fraseArray.Length == 1 ? "" : "s", fraseArray.Length == 1 ? "" : "na frase");

                continuar = VoltarParaOMenu();

            } while (continuar);
        }

        private static void Exercicio03(ref bool continuar)
        {
            do
            {
                Console.Clear();

                Console.Write("Digite um número para fazer a codificação: ");

                int numero = ValidarNumero();

                Console.Write("Digite algo para codificá-lo: ");

                string palavra = Console.ReadLine().ToUpper();

                string palavraCodificada = "";

                char[] palavraChar = palavra.ToCharArray();

                for (int i = 0; i < palavraChar.Length; i++)
                {
                    palavraCodificada += (char)((int)palavraChar[i] + numero);
                }

                Console.WriteLine(palavraCodificada);

                continuar = VoltarParaOMenu();

            } while (continuar);
        }

        private static void Exercicio04(ref bool continuar)
        {
            do
            {
                Console.Clear();

                int resultado;

                int maiorResultado = 0;

                string maiorResultadoString = "";

                string numeroCalculo;

                string numeros = "73167176531330624919225119674426574742355349194934" +
                                 "96983520312774506326239578318016984801869478851843" +
                                 "85861560789112949495459501737958331952853208805511" +
                                 "12540698747158523863050715693290963295227443043557" +
                                 "66896648950445244523161731856403098711121722383113" +
                                 "62229893423380308135336276614282806444486645238749" +
                                 "30358907296290491560440772390713810515859307960866" +
                                 "70172427121883998797908792274921901699720888093776" +
                                 "65727333001053367881220235421809751254540594752243" +
                                 "52584907711670556013604839586446706324415722155397" +
                                 "53697817977846174064955149290862569321978468622482" +
                                 "83972241375657056057490261407972968652414535100474" +
                                 "82166370484403199890008895243450658541227588666881" +
                                 "16427171479924442928230863465674813919123162824586" +
                                 "17866458359124566529476545682848912883142607690042" +
                                 "32421902267105562632111110937054421750694165896040" +
                                 "07198403850962455444362981230987879927244284909188" +
                                 "84580156166097919133875499200524063689912560717606" +
                                 "05886116467109405077541002256983155200055935729725" +
                                 "71636269561882670428252483600823257530420752963450";

                for (int i = 0; i < numeros.Length; i += 5)
                {
                    resultado = 1;

                    numeroCalculo = numeros.Substring(i, 5);

                    resultado = (int)Char.GetNumericValue(numeroCalculo[0]) * (int)Char.GetNumericValue(numeroCalculo[1]);

                    for (int j = 2; j < numeroCalculo.Length; j++)
                    {
                        resultado = resultado * (int)Char.GetNumericValue(numeroCalculo[j]);
                    }

                    if (resultado > maiorResultado)
                    {
                        maiorResultado = resultado;
                        maiorResultadoString = numeroCalculo;
                    }
                }

                Console.WriteLine($"O maior resultado foi da sequência {maiorResultadoString} com um total de {maiorResultado}");

                continuar = VoltarParaOMenu();

            } while (continuar);
        }

        private static void Exercicio05(ref bool continuar)
        {
            do
            {
                Console.Clear();

                Console.Write("Digite uma frase: ");

                string frase = Console.ReadLine();
                string[] fraseArray = frase.Split(" ");
                int contadorEspacos = 0;

                for (int i = 0; i < frase.Length; i++)
                {
                    if (frase[i] == ' ')
                    {
                        contadorEspacos++;
                    }
                }

                PulaLinha();

                Console.WriteLine("Letra Maiúscula: " + frase.ToUpper());
                Console.WriteLine("Letra Minúscula: " + frase.ToLower());
                Console.WriteLine("Número de Caracteres sem espaços: " + (frase.Length - contadorEspacos));
                Console.WriteLine("Primeira palavra: " + fraseArray[0]);
                Console.WriteLine("Última palavra: " + fraseArray[fraseArray.Length - 1]);

                continuar = VoltarParaOMenu();

            } while (continuar);
        }

        private static void Exercicio06(ref bool continuar)
        {
            do
            {
                Console.Clear();

                string municipios = File.ReadAllText(@"C:\Users\João\Desktop\AP\Aula-17\Cidades.csv");

                string[] municipiosLinhaALinha = municipios.Split('\n');

                Console.WriteLine("Entre as opções abaixo:");
                Console.WriteLine("(1)Mostrar Lista");
                Console.WriteLine("(2)Mostrar Lista com Cidades em ordem alfabética");
                Console.WriteLine("(3)Mostrar Lista com Estados em ordem alfabética");

                PulaLinha();

                Console.Write("O que deseja fazer? ");

                int opcaoEscolhida = ValidarNumero();

                switch (opcaoEscolhida)
                {
                    case 1: Console.WriteLine(string.Join("\n", municipiosLinhaALinha)); break;
                    case 2: CidadesOrdemAlfabetica(municipiosLinhaALinha); break;
                    case 3: EstadosOrdemAlfabetica(municipios, municipiosLinhaALinha); break;
                    default: break;
                }

                continuar = VoltarParaOMenu();

            } while (continuar);
        }

        private static void CidadesOrdemAlfabetica(string[] municipiosArray)
        {
            string[] cidadesOrdenadas = new string[municipiosArray.Length];

            string[] cidadesNaoOrdenadas = new string[municipiosArray.Length];

            int indiceCidade = 11;
            int indiceCidadeMulti = 10;

            for (int i = 0; i < municipiosArray.Length - 1; i++)
            {

                cidadesOrdenadas[i] = municipiosArray[i].Substring(indiceCidade, 16);

                if (i == indiceCidadeMulti - 1)
                {
                    indiceCidadeMulti *= 10;
                    indiceCidade++;
                }
            }

            int[] indicesCidadesOrdenadas = Enumerable.Range(0, cidadesOrdenadas.Length).ToArray();

            Array.Copy(cidadesOrdenadas, cidadesNaoOrdenadas, cidadesOrdenadas.Length);

            Array.Sort(cidadesOrdenadas);

            for (int i = 0; i < cidadesOrdenadas.Length; i++)
            {
                indicesCidadesOrdenadas[i] = Array.IndexOf(cidadesNaoOrdenadas, cidadesOrdenadas[i]);
            }

            for (int i = 0; i < municipiosArray.Length - 1; i++)
            {
                Console.WriteLine(municipiosArray[indicesCidadesOrdenadas[i]]);
            }
        }

        private static void EstadosOrdemAlfabetica(string municipios, string[] municipiosArray)
        {
            string[] estadosOrdenados;

            string[] estadosNaoOrdenados;

            estadosOrdenados = municipios.Split("; ");

            estadosNaoOrdenados = municipios.Split("; ");

            int[] indicesEstadosOrdenados = Enumerable.Range(0, estadosOrdenados.Length).ToArray();

            Array.Sort(estadosOrdenados);

            for (int i = 0; i < estadosOrdenados.Length; i++)
            {
                indicesEstadosOrdenados[i] = Array.IndexOf(estadosNaoOrdenados, estadosOrdenados[i]);
            }

            for (int i = 0; i < municipiosArray.Length - 1; i++)
            {
                Console.WriteLine(municipiosArray[indicesEstadosOrdenados[i]]);
            }
        }

        static void PulaLinha()
        {
            Console.WriteLine();
        }

        static int ValidarNumero()
        {
            bool validaNumero;
            int numero;

            do
            {
                string entrada = Console.ReadLine();

                validaNumero = int.TryParse(entrada, out numero);

            } while (!validaNumero);

            return numero;
        }

        static bool VoltarParaOMenu()
        {
            string entrada;

            PulaLinha();

            Console.WriteLine("Quer sair do exercício? (S/N)");

            do
            {
                entrada = Console.ReadLine().ToUpper();

            } while (entrada != "S" && entrada != "N");

            return entrada == "S" ? false : true;
        }
    }
}