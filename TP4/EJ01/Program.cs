using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ01
{
    class Program
    {
        static void Main(string[] args)
        {
            ControladorFachada fachada = new ControladorFachada();

            Console.WriteLine("Ingrese dividendo");
            string dividendo  = Console.ReadLine();
            int dividendoConvertido = Convert.ToInt32(dividendo);
            Console.WriteLine();

            Console.WriteLine("Ingrese dividendo");
            string divisor = Console.ReadLine();
            int divisorConvertido = Convert.ToInt32(divisor);
            Console.WriteLine();

            try
            {
                double resultado = fachada.Dividir(dividendoConvertido, divisorConvertido);
                Console.WriteLine($"{dividendoConvertido} / {divisorConvertido} = {resultado:0.0}");
            }
            catch (DivisorPorCeroException)
            {
                Console.WriteLine("Error: se ha intentado dividir por cero.");
            }

            Console.ReadKey();
        }
    }
}
