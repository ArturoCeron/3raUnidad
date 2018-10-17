using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace E3_2_CeronUribeArturo
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            Queue cola = new Queue(); //Crea el objeto

            cola.Enqueue("Madrugada"); //El metodo Enqueue es como si fuera el push en la pila
            cola.Enqueue("Vida en el espejo"); //Se agregan 4 elementos a la cola
            cola.Enqueue("Elemento");
            cola.Enqueue("Mania cardiáca");

            for (contador = 0; contador < 4; contador++ )
            {
                Console.WriteLine(cola.Dequeue()); //Dequeue es como el pop en pilas, retorna un valor y luego lo 
            }                                       // Elimina

            cola.TrimToSize(); //Establece la capacidad de la cola al numero de elementos que hay actualmente

            Console.WriteLine(cola.Count); //Imprime la cantidad de elementos que tiene
            Console.ReadKey();
        }
    }
}
