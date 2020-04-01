using System;

namespace Ejercicio_Conjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");
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
        static void anadirDato()
        {
            Console.Write("pon lo que quieras añadir");
            string datoAnadir = Console.ReadLine();
            if (cantidad<capacidad)
            {
                nombre[cantidad] = datoAnadir;
                cantidad++;
            }
        }

        static void mostrarDatos()
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("{0}, ",nombres[i]);
            }
        }
        
        static void Salir()
        {
            else
                    {
                        Console.Write("No hay más opciones");
                        i = 5;
                    }
        }
                   
    }
}
