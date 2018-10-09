using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E31_CeronUribeArturo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroClases;

            Console.Write("Cuantas clases va a ingresar: ");
            numeroClases = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Calificaciones proceso = new Calificaciones();

            proceso.Capturar(numeroClases);

            Console.ReadKey();
        }
    }
}
