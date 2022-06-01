using System;
namespace Calculadora
{
    public class Multiplicacao : Calculadora
    {
        public Multiplicacao(int num) : base(num){}
        public override void Calcular()
        {
            Console.WriteLine("\nDiga dois numeros para multiplicar...");
            
            Console.Write("Numero a ser multiplicado: ");
            base.num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Multiplicador: ");
            base.num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\nMultiplicando.....");
            base.resultado = num1 * num2;

            Console.WriteLine($"\n{num1} X {num2} = " + resultado);
            base.Calcular();

            Console.ReadKey();
            Console.Clear();
        }
    }
}