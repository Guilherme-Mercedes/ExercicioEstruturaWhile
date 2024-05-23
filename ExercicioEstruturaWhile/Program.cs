using System.Drawing;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace ExercicioEstruturaWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Exercicio2();
        }


        static void Exercicio0()
        {
            double x, raiz;

            Console.WriteLine("Digite um numero: ");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)
            {
                raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite um numero: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("O resultado deu negativo.");
        }

       /* Escreva um programa que repita a leitura de uma senha até que ela seja válida.Para cada leitura de senha
        incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
        impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.*/
        static void Exercicio1()
        {
            int senha;

            Console.WriteLine("Digite a senha: ");
            senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha invalida");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Digite a senha: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido");
        }

        /* Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva 
            algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 
            4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até 
            que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a 
            mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme 
            exemplo. */
        static void Exercicio2()
        {
            int n, alcool = 0, gasolina = 0, diesel = 0;

            Console.WriteLine("Escolha o combustivel: ");
            Console.WriteLine("1 - Alcool");
            Console.WriteLine("2 - Gasolina");
            Console.WriteLine("3 - Diesel");
            Console.WriteLine("4 - Fim");
            n = int.Parse(Console.ReadLine());

            while(n != 4)
            {
                if (n == 1)
                {
                    alcool = alcool + 1;
                }
                else if (n == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if(n == 3) 
                { 
                    diesel = diesel + 1;
                }
                else
                {
                    Console.WriteLine("Digite um codigo valido: ");
                }

                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito obrigado");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }

    }
}
