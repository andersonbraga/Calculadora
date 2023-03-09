using System.Threading.Channels;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
   

            do
            {

                Console.Clear();
                Console.WriteLine("Calculadora Top 2023");
                Console.WriteLine("Digite 1 para Somar");
                Console.WriteLine("Digite 2 para Subtrair");
                Console.WriteLine("Digite 3 para Multiplicação");
                Console.WriteLine("Digite 4 para Divisão");

            

                string operacao = Console.ReadLine();

                Console.WriteLine("Digite o primeiro numero");
                decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite o segundo numero");
                decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

                decimal resultado = 0;

                bool ehAdicao = operacao == "1";
                bool ehSubtracao = operacao == "2";
                bool ehMultiplicacao = operacao == "3";
                bool ehDivisao = operacao == "4";

                switch (operacao)
                {
                    case "1": resultado = primeiroNumero + segundoNumero; break;
                    case "2": resultado = primeiroNumero - segundoNumero; break;
                    case "3": resultado = primeiroNumero * segundoNumero; break;
                    case "4":
                    {
                        if (segundoNumero == 0)
                        {
                            Console.WriteLine("Não e possivel dividir por 0 ");
                            Console.ReadLine();
                            Console.WriteLine("Digite o segundo numero ");
                            segundoNumero = Convert.ToInt32(Console.ReadLine());
                            continue;
                        }
                        resultado = primeiroNumero / segundoNumero;
                        }; break;

                    default:
                        break;

                }

                //if (ehAdicao)
                //{
                //    resultado = primeiroNumero + segundoNumero;

                //}

                //else if (ehSubtracao)
                //{
                //    resultado = primeiroNumero - segundoNumero;
                //}
                //else if (ehMultiplicacao)
                //{
                //    resultado = primeiroNumero * segundoNumero;
                //}
                //else if (ehDivisao)
                //{
                //    if (segundoNumero == 0)
                //    {
                //        Console.WriteLine("Não e possivel dividir por 0 ");
                //        continue;
                //    }
                //    resultado = primeiroNumero / segundoNumero;

                //}

                decimal resultadoFormatado = Math.Round(resultado, 2);
                Console.WriteLine($"O resultado da operação é: {resultadoFormatado}");
                Console.ReadLine();
                
            } while (true);

        }
    }
}