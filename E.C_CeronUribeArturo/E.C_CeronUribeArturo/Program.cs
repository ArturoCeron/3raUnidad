using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace E.C_CeronUribeArturo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pila = new Stack();

            pila.Push("Sencillo");
            pila.Push("Complejo");
            pila.Push("Radical");
            pila.Push("Denso");

            //Se compara para saber si un elemento se encuetra dentro de la pila
            if (pila.Contains("Denso"))
                Console.WriteLine("Denso\n");
            else
                Console.WriteLine("1.-This world is a better place without her\n");
            Console.Clear();
            //Se compara para saber el tipo del objeto
            if (pila.GetType() == typeof(Stack))
                Console.WriteLine("si es del tipo\n");
            else
                Console.WriteLine("No es el tipo\n");

            //Retorna un string del objeto seleccionado
            Console.WriteLine("o" + pila.ToString() + "\n");

            //Convierte la pila en arreglo
            Console.WriteLine(pila.ToArray().ElementAt(3) + "\n");

            //Consigue el numerador de la pila
            IEnumerator numerador= pila.GetEnumerator();
            while (numerador.MoveNext())
            {
                Object objeto = numerador.Current;
                Console.WriteLine(objeto);
            }
            Console.ReadKey();
        }
    }
}