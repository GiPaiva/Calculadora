using System;
namespace Calculadora
{
    public class Subtracao : Calculadora
    {
        public Subtracao(int num) : base(num){}
        public override void Calcular()
        {
            Console.WriteLine("\nDiga dois numeros para subtrair...");
            
            Console.Write("Primeiro numero: ");
            base.num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Segundo numero: ");
            base.num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSubtraindo.....");
            base.resultado = num1 - num2;
            base.Calcular();
            Console.WriteLine($"\n{num1} - {num2} = " + resultado);

            Console.ReadKey();
            Console.Clear();
        }
    }
}