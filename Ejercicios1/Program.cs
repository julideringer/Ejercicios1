using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos variables
            double longitudRadio;
            double areaCirculo;
            double longitudCircunferencia;
            const double pi1 = 3.1416;
            const double pi2 = 3.1415927;

            //Introducimos valor de la longitud del radio
            Console.WriteLine("Introduzca longitud de radio:");
            string radio = Console.ReadLine();
            double.TryParse(radio, out longitudRadio);

            //Realizamos las operaciones del área del circulo y la longitud de la circunferencia correspondientes
            areaCirculo = pi2 * Math.Pow(longitudRadio, 2);
            longitudCircunferencia = 2 * pi2 * longitudRadio;

            Console.WriteLine(""+ areaCirculo +"  "+ longitudCircunferencia);

            Console.ReadLine();
        }
    }
}
