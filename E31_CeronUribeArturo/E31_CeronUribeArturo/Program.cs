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

            Console.Write("Cuantas clases va a ingresar: "); //Ingresa y guarda la cantidad de clases
            numeroClases = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Calificaciones proceso = new Calificaciones(); //Se crea el objeto de la clase Calificaciones
 
            proceso.Capturar(numeroClases); //Se manda a llamar al método Capturar y se manda como parametro numeroClases

            Console.ReadKey();
        }
    }
}
