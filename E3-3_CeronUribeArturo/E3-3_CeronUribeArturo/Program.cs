using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_3_CeronUribeArturo
{
    class Program
    {
        static void Main(string[] args)
        {
            Juego jugar = new Juego();
            try
            {
                jugar.empezar(); //Manda a llamar al metodo
            }
            catch (Exception e) //Excepción por seguridad
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
