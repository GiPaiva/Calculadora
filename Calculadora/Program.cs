using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora[] calc = new Calculadora[6];

            calc[0] = new Soma(0);
            calc[1] = new Subtracao(0);
            calc[2] = new Divisao(0);
            calc[3] = new Multiplicacao(0);
            calc[4] = new Potenciacao(0);
            calc[5] = new Raiz(0);

            int i = 0;
            do
            {
                Console.WriteLine("\nBora calcular....");
                //+,-,/,*,^,raiz
                Console.WriteLine
                ("\nQual o calculo? \n [0]Soma        [1]Subtração \n [2]Divisao     [3]Multiplicação \n [4]Potenciação [5]Raiz ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Calculando(calc[n]);
                Console.Clear();

                Console.WriteLine("Quer continuar? [1]Sim [2]Não");
                i = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

            }while(i == 1);

            static void Calculando(Calculadora calc)
            {
                Console.WriteLine(calc.Calcular);
                calc.Calcular();
            }
        }
    }
}