using System;
namespace Calculadora
{
    public class Soma : Calculadora
    {
        public Soma(int num) : base(num){}
        public override void Calcular()
        {
            Console.WriteLine("\nDiga dois numeros para somar...");
            
            Console.Write("Primeiro numero: ");
            base.num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Segundo numero: ");
            base.num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSomando.....");
            base.resultado = num1 + num2;
            Console.WriteLine($"\n{num1} + {num2} = " + resultado);
            base.Calcular();
            
            Console.ReadKey();
            Console.Clear();
        }
    }
}