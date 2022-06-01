using System;
namespace Calculadora
{
    public class Raiz : Calculadora
    {
        public Raiz(int num) : base(num){}
        public override void Calcular()
        {
            Console.WriteLine("\nDiga dois numeros para a raiz matemática...");
            
            Console.Write("Radical: ");
            base.num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indice: ");
            base.num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nRadicando.....")
            ;
            base.resultado = Math.Pow(num1, 1.0/num2);
            Console.WriteLine($"\n{num2} √ {num1} = " + resultado);
            base.Calcular();
            
            Console.ReadKey();
            Console.Clear();
        }
    }
}