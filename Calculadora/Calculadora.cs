namespace Calculadora
{
     public abstract class Calculadora
    {
        private double num;
        public double Num
        {
            get { return num; }
            set { num = value; }
        }
        
        protected double num1;
        protected double num2;
        protected double resultado;

        public Calculadora(double num)
        {
            this.num = num;
        }

        public virtual void Calcular(){}
        
    }
}