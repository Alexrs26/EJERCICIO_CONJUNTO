using System;

namespace Ejercicio_Conjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
              string[] nombres = { "ALEX", "ELISABETH", "DIEGO", "", " ", " ", " ", " ", " ", " "};
              int capacidad = 10;
              int cantidad = 3;
              int i;
                int n;
                Console.WriteLine("Datos iniciales: ");
                for (i = 0; i < cantidad; i++)
                    Console.Write("{0} ", nombres[i]);
                Console.WriteLine();
                while ( i <=4)
                {
                    if (cantidad < capacidad)
                    {
                        Console.WriteLine("\nMenú");
                        Console.WriteLine("Pulsa 1 para añadir un nombre al final");
                        Console.WriteLine("Pulsa 2 para mostrar los datos");
                        Console.WriteLine("Pulsa 3 para buscar a partir de una letra");
                        Console.WriteLine("Pulsa 4 para salir de programa");    

                        Console.Write("\nOPCIÓN: ");
                        
                        i = Convert.ToInt32(Console.ReadLine());
                        if ( i == 1)
                        {
                            Console.Write("¿Qué nombre quieres añadir?: ");
                            string nombre1 = Console.ReadLine();
                            nombres[cantidad] = nombre1;
                            cantidad++;
                        }
                        else if (i == 2)
                        {
                            for (n = 0; n < cantidad; n++)
                            {
                                Console.Write(nombres[n]);
                                Console.Write(" ");
                            }
                            Console.Write("");
                        } 
                        else if ( i == 3)
                        {
                            Console.Write("Teclea la letra a partir de la que quieras buscar (en mayúsculas): ");
                            char letraBuscar = Convert.ToChar(Console.ReadLine());

                            for (n = 0; n < cantidad; n++)
                            {
                                if (nombres[n].Contains(letraBuscar))
                                {
                                    Console.WriteLine(nombres[n]);
                                }
                            }
                        }  
                        else if (i == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("Cerrando programa...");
                            break;
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

