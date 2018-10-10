using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E31_CeronUribeArturo
{
    class Calificaciones
    {
        public void Capturar(int numeroClases)
        {
            ArrayList listaClases = new ArrayList();
            ArrayList cantidadAlumnos = new ArrayList(); //Se crean las listas necesarias
            ArrayList listaCalificaciones = new ArrayList();
            int contador = 0;
            int calificacion = 0;
            int materia = 0;

            for (contador = 0; contador < numeroClases; contador++) //Se piden los nombres de las clases
            {
                Console.Write("Ingrese el nombre de la clase {0}: ", contador + 1);
                listaClases.Add(Console.ReadLine());
                Console.Write("\n");
            }

            Console.Clear();

            for (contador = 0; contador < numeroClases; contador++) //Se ingresan los alumnos de cada clase
            {
                Console.Write("Cuantos alumnos va a tener la materia de {0}: ", listaClases.ToArray().ElementAt(contador));
                cantidadAlumnos.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.Clear();

            for (materia = 0; materia < numeroClases; materia++)//Se usa un doble for para poder desplegar el nombre de la clase y pedir la calificacion
            {							// de cada alumno
                for (contador = 0; contador < Convert.ToInt32(cantidadAlumnos.ToArray().ElementAt(materia)); contador++)
                {
                    Console.Write("Ingrese la calificación del alumno {0} de la materia {1}: ", contador + 1, listaClases.ToArray().ElementAt(materia));
                    listaCalificaciones.Add(Console.ReadLine());
                    Console.Write("\n");
                }
            }
            Console.Clear();
            materia = 0;
            foreach (object valor in listaClases) //El foreach desplegará cada uno de los elementos de listaClases
            {
                Console.WriteLine(valor + ":");
                for (contador = 0; contador < Convert.ToInt32(cantidadAlumnos.ToArray().ElementAt(listaClases.IndexOf(valor))); contador++)
                {					//El for desplegará cada una de las calificaciones del elemento según sean la cantidad de alumnos por clase
                    Console.WriteLine("Alumno {0}: {1}", contador + 1, listaCalificaciones.ToArray().ElementAt(calificacion));
                    calificacion++;
                }
            }
        }
    }
}
