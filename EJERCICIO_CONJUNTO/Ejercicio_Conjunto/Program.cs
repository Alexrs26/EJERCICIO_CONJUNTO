using System;

namespace Ejercicio_Conjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
              string[] nombres = { "Alex", "Elisabeth", "Diego", "", " ", " ", " ", " ", " ", " "};
              int capacidad = 10;
              int cantidad = 3;
              int i;
                int n;
                for (i = 0; i < cantidad; i++)
                    Console.Write("{0} ", nombres[i]);
                Console.WriteLine();
                while ( i != 5)
                {
                    if (cantidad < capacidad)
                    {
                        Console.WriteLine("Menú");
                        Console.WriteLine("Pulsa 1 para añadir un nombre al final");
                        Console.WriteLine("Pulsa 2 para insertar un dato en una posición");
                        Console.WriteLine("Pulsa 3 para borrar un dato");
                        Console.WriteLine("Pulsa 4 para mostrar los datos");
                        Console.WriteLine("Pulsa 5 para salir de programa");
                        i = Convert.ToInt32(Console.ReadLine());
                        if ( i == 1)
                        {
                            Console.WriteLine("¿Qué nombre quieres añadir?");
                            string nombre1 = Console.ReadLine();
                            nombres[cantidad] = nombre1;
                            cantidad++;
                        }
                        else if (i == 2)
                        {
                            Console.WriteLine("¿Qué nombe quieres insertar?");
                            string nombre2 = Console.ReadLine();
                            Console.WriteLine("¿En qué posición");
                            int posicion = Convert.ToInt32(Console.ReadLine());
                            if (posicion <= cantidad && 1<= posicion)
                            {
                                for (n = cantidad; n > posicion -1; n--)
                                {
                                    nombres[n] = nombres[n - 1];
                                }
                            }
                            else
                            {
                                Console.WriteLine("La posición no existe.");
                            }
                        } 
                        else if ( i == 3)
                        {
                            Console.WriteLine("Qué posición quieres borrar?");
                            int posicionB = Convert.ToInt32(Console.ReadLine());
                            nombres[posicionB] = " ";
                        }
                        else if (i == 4)
                        {
                            for (n=0; n < cantidad; n++)
                            {
                                Console.Write(nombres[n]);
                                Console.Write(" ");                                    
                            }
                            Console.Write("");
                        }
                    }
                    else
                    {
                        Console.Write("No hay más opciones");
                        i = 5;
                    }
                }                   
            }
            catch (OverflowException)
            {
                Console.WriteLine("numero no valido");
            }
            catch (FormatException)
            {
                Console.WriteLine("formato no valido");
            }
        }
    }
}
