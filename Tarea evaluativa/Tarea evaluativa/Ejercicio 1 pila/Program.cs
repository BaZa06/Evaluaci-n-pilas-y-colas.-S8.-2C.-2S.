using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicio_1_pila
{
    internal class Program
    {
        //Ejercicios:
        //Declarar una pila utilizando una estructura adecuada (arreglo o clase Stack en C#).
        //Permitir al usuario ingresar varios números enteros para apilarlos(push).
        //Mostrar los elementos actuales de la pila.
        //Eliminar el último elemento ingresado(pop).
        //Mostrar nuevamente la pila después de la eliminación.
        //Comprobar si la pila está vacía o no antes de extraer un elemento.
        static void Main(string[] args)
        {
            Stack<int> enteros = new Stack<int>();

           
            int opcion;

            do
            {
                Console.WriteLine("MENÚ");
                Console.WriteLine("1. Agregar número");
                Console.WriteLine("2. Mostrar número");
                Console.WriteLine("3. Eliminar último número");
                Console.WriteLine("4. Salir");
                Console.Write("Elige una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        // Ingresar números a la pila
                        Console.Write("Ingresa un número entero: ");
                        int numero = Convert.ToInt32(Console.ReadLine());
                        //Agrega número a la pila y es colocado en la parte superior
                        enteros.Push(numero);
                        Console.WriteLine($"Número {numero} agregado a la pila.");
                        break;

                    case 2:
                        // Mostrar los elementos actuales de la pila
                        if (enteros.Count > 0)
                        {
                            Console.WriteLine("Elementos ingresados:");
                            foreach (int n in enteros)
                            {
                                Console.WriteLine(n);
                            }
                        }
                        else
                        {
                            Console.WriteLine("La pila vacía.");
                        }
                        break;

                    case 3:
                        // Verificar si la pila está vacía antes de extraer
                        if (enteros.Count > 0)
                        {
                            // Elimina el último número ingresado
                            int eliminado = enteros.Pop();
                            Console.WriteLine($"Elemento eliminado: {eliminado}");

                            // Mostrar nuevamente la pila
                            if (enteros.Count > 0)
                            {
                                Console.WriteLine("Pila actual:");
                                foreach (int n in enteros)
                                {
                                    Console.WriteLine(n);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Pila vácia.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Pila vácia, imposibilidad de eliminar número");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }

            } while (opcion != 4); //Seguirá funcionando mientras la opción elegida no sea 4
    }
}
