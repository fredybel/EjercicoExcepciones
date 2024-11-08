
namespace EjercicoExcepciones
{
    public class Operaciones 
    {

        public double N1;
        public double N2;
        public double Sumar(double N1, double N2)
        {
            return N1 + N2;
        }
        public double Restar(double N1, double N2)
        {
            return N1 - N2;
        }
        public double Multiplicar(double N1, double N2)
        {
            return N1 * N2;
        }
        public double Division(double N1, double N2)
        {
            if(N2 != 0)
            {
                return N1 / N2;
            }
            
            Console.WriteLine("No se puede dividir por cero");
        }
    }

}
