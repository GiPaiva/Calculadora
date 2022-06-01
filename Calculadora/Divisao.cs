using System;
namespace Calculadora
{
    public class Divisao : Calculadora
    {
        public Divisao(int num) : base(num){}
        public override void Calcular()
        {
            Console.WriteLine("\nDiga dois numeros para dividir...");
            
            Console.Write("Numero a dividir: ");
            base.num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dividido por quanto? ");
            base.num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDividindo.....");
            base.resultado = num1 / num2;
            double rest = num1 % num2;

            Console.WriteLine($"\n{num1} / {num2} = " + resultado);
            Console.WriteLine("Restando: " + rest);

            base.Calcular();           
            Console.ReadKey();
            Console.Clear();
        }
    }
}