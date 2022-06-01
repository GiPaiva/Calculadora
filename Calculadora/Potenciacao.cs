using System;
namespace Calculadora
{
    public class Potenciacao : Calculadora
    {
        public Potenciacao(int num) : base(num){}
        public override void Calcular()
        {
            Console.WriteLine("\nDiga dois numeros para fazer a potenciação...");
            
            Console.Write("Base: ");
            base.num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Expoente: ");
            base.num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nFazendo a potenciação.....");
            base.resultado = Math.Pow(num1,num2);
            Console.WriteLine($"\n{num1} ^ {num2} = " + resultado);
            base.Calcular();
            
            Console.ReadKey();
            Console.Clear();
        }
    }
}