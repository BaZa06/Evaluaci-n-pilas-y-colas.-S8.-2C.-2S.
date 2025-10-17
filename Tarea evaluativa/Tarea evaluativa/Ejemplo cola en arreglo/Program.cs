using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_cola_en_arreglo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 10; // Tamaño máximo de la cola
            int[] cola = new int[MAX];
            int frente = 0; // Posición del primer elemento
            int fin = -1;   // Posición del último elemento
            int cantidad = 0; // Cantidad de elementos en la cola
            int opcion;

            do
            {
                Console.WriteLine("MENÚ");
                Console.WriteLine("1. Agregar número");
                Console.WriteLine("2. Mostrar números");
                Console.WriteLine("3. Eliminar número");
                Console.WriteLine("4. Salir");
                Console.Write("Elige una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1: // Agregar en ez de ENQUEUE
                        if (cantidad < MAX)
                        {
                            Console.Write("Ingresa un número entero: ");
                            int numero = Convert.ToInt32(Console.ReadLine());
                            fin = (fin + 1) % MAX; // Mueve el índice 
                            cola[fin] = numero;
                            cantidad++;
                            Console.WriteLine($"Número {numero} agregado a la cola.");
                        }
                        else
                        {
                            Console.WriteLine("Cola llena.");
                        }
                        break;

                    case 2: // Mostrar cola al agregar
                        if (cantidad > 0)
                        {
                            Console.WriteLine("Elementos en la cola:");
                            for (int i = 0; i < cantidad; i++)
                            {
                                int indice = (frente + i) % MAX; 
                                Console.WriteLine(cola[indice]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Cola vacía.");
                        }
                        break;

                    case 3: // Eliminar en vez de DEQUEUE
                        if (cantidad > 0)
                        {
                            Console.WriteLine($"Elemento eliminado: {cola[frente]}");
                            frente = (frente + 1) % MAX; // Avanza al siguiente elemento
                            cantidad--;
                            if (cantidad == 0)
                                Console.WriteLine("Cola vacía, elemento eliminado.");
                        }
                        else
                        {
                            Console.WriteLine("No se puede eliminar número, cola vacía.");
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
