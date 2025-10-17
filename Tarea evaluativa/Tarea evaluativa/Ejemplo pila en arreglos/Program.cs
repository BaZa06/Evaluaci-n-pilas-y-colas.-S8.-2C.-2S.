using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_pila_en_arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 10; // Tamaño máximo de la pila
            int[] pila = new int[MAX];
            int tope = -1; // Índice del último número agregado
            int opcion;

            do
            {
                Console.WriteLine("MENÚ");
                Console.WriteLine("1. Agregar número");
                Console.WriteLine("2. Mostrar pila");
                Console.WriteLine("3. Eliminar último número");
                Console.WriteLine("4. Salir");
                Console.Write("Elige una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1: // Agregar en ez de PUSH
                        if (tope < MAX - 1)
                        {
                            Console.Write("Ingresa un número entero: ");
                            int numero = Convert.ToInt32(Console.ReadLine());
                            tope++; // Se acumulan los números
                            pila[tope] = numero;
                            Console.WriteLine($"Número {numero} agregado a la pila.");
                        }
                        else
                        {
                            Console.WriteLine("La pila está llena.");
                        }
                        break;

                    case 2: // Mostrar pila al agregar
                        if (tope >= 0)
                        {
                            Console.WriteLine("Registro de números:");
                            for (int i = tope; i >= 0; i--)
                            {
                                Console.WriteLine(pila[i]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("La pila está vacía.");
                        }
                        break;

                    case 3: // Eliminación en vez de POP
                        if (tope >= 0)
                        {
                            Console.WriteLine($"Número eliminado: {pila[tope]}");
                            tope--; // Eliminamos el elemento del tope
                            if (tope < 0)
                                Console.WriteLine("La pila está vacía. Eliminación exitosa");
                        }
                        else
                        {
                            Console.WriteLine("No se puede eliminar el número, pila está vacía.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 4);
        }
    }
}
