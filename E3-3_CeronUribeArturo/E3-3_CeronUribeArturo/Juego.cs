using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace E3_3_CeronUribeArturo
{
    class Juego
    {
        Stack pilaCartas = new Stack();
        Carta cartaNueva;                       //Inicializa listas y pilas
        List<Carta> lista = new List<Carta>();
        int suma = 0;
        int cantidadAces = 0;
        int cantidadCartas = 0; //Variables auxiliares para el programa
        int victorias = 0;
        int derrotas = 0;
        string continua = "Y";
        public void sacarAleatorio()
        {
            Random elegir = new Random();
            int aleatorio = 0;
            aleatorio = elegir.Next(0, lista.Count);
            pilaCartas.Push(lista.ElementAt(aleatorio)); //Obtiene el valor aleatorio y lo guarda en la pila
            cantidadCartas = cantidadCartas + 1;
            lista = (from carta in lista where carta.id != lista.ElementAt(aleatorio).id select carta).ToList();         
        }

        public void rellenar()
        {

            int contadorValores = 0;
            int contadorFiguras = 0;
            char[] figuras = new char[4] { '♥', '♦', '♣', '♠' }; //Simbolos para las cartas
            char[] letras = new char[3] { 'J', 'Q', 'K' };

            

            for (contadorFiguras = 0; contadorFiguras < 4; contadorFiguras++ )
            {
                for(contadorValores = 1; contadorValores < 14; contadorValores++)
                {
                    cartaNueva = new Carta();
                    if(contadorValores > 10)
                    {
                        cartaNueva.id = Convert.ToString(letras[contadorValores - 11]) + Convert.ToString(figuras[contadorFiguras]); //Llena la lista con los valores de J Q K
                        cartaNueva.valor = 10;
                    }
                    else if(contadorValores == 1)
                    {
                        cartaNueva.id = "As" + Convert.ToString(figuras[contadorFiguras]); //Ingresa un "As" en lugar de 1
                        cartaNueva.valor = 0;
                    }
                    else
                    {
                        cartaNueva.id = Convert.ToString(contadorValores) + Convert.ToString(figuras[contadorFiguras]); //Ingresa los valores del 2 al 10
                        cartaNueva.valor = contadorValores;
                    }
                    lista.Add(cartaNueva); //Agrega los valores a la lista
                }
            }
        }

        public void mostrarMano()
        {
            foreach (Carta item in pilaCartas)
            {
                Console.WriteLine(item.id); //Muestra las cartas que se tienen en mano
            }
        }

        public void comprobarSumas()
        {
            suma = 0;
            foreach (Carta item in pilaCartas)
            {
                if(item.valor >= 2 && item.valor <= 10)
                {
                    suma = suma + item.valor; //Suma los valores que no sean aces
                }
                else
                {
                    cantidadAces = cantidadAces + 1; //Guarda la cantidad de aces
                }

            }
                for (cantidadAces = cantidadAces; cantidadAces > 0; cantidadAces--) //Repite la cantidad de aces que se tengan
                {
                    if (suma <= 10)
                    {
                        suma = suma + 11; //Si la suma es menor a 10 se usa el as como 11
                    }
                    else if (suma > 10)
                    {
                        suma = suma + 1; //Si es mayor a 10 se usa como 1
                    }
                }
        }

        public void reiniciar()
        {
            lista.Clear();
            pilaCartas.Clear();
            suma = 0;
            cantidadAces = 0; //Limpia todos los valores
            cantidadCartas = 0;
            Console.Clear();    
            rellenar();

        }

        public void empezar()
        {
            Console.OutputEncoding = Encoding.Unicode; //Para que se muestren las figuras
            string opcion = "Y";  
            rellenar(); 
            while(continua == "Y")
            {
                sacarAleatorio();
                do
                {
                    sacarAleatorio();
                    mostrarMano(); //Llama los metodos para empezar a jugar
                    comprobarSumas();
                    Console.WriteLine(suma);//Despliega cuanto valor va en la mano
                    if (suma < 21 && cantidadCartas < 5)
                    {
                        Console.Write("¿Desea tomar otra carta?\n Presione Y para continuar, cualquier otra tecla para salir: ");
                        opcion = Console.ReadLine().ToUpper();
                        if (opcion != "Y")
                        {
                            derrotas = derrotas + 1; //Si el jugador no toma otra carta cuenta como derrota
                            Console.WriteLine("Ha perdido");
                        }
                    } 
                    else if (cantidadCartas == 5) //Verifica que tenga menos de 5 cartas
                    {
                        if (suma <= 21)
                        {
                            Console.WriteLine("Ha ganado"); //Si es menor o igual a 21 gana
                            victorias = victorias + 1;
                        }
                        else //De lo contrario pierde
                        {
                            Console.WriteLine("Ha perdido");
                            derrotas = derrotas + 1;
                        }
                    }
                    else if (suma == 21)
                    {
                        Console.WriteLine("Ha ganado"); //Si es igual a 21 gana
                        victorias = victorias + 1;
                    }
                    else //Si son mas de 5 cartas pierde
                        {
                            Console.WriteLine("Ha perdido");
                            derrotas = derrotas + 1;
                        }
                } while (opcion == "Y" && suma < 21 && cantidadCartas < 5);
                Console.WriteLine("¿Desea jugar otra vez?\n Presione Y para continuar, cualquier otra tecla para salir: ");
                continua = Console.ReadLine().ToUpper();
                reiniciar(); //Reinicia todos los valores

            }
            Console.WriteLine("Resultados: \nVictorias: {0} \nDerrotas: {1}", victorias, derrotas);        //Despliega la cantidad de victorias y derrotas    
        }
    }
}
