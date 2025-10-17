using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_cola
{
    internal class Program
    {
        //Problema a resolver:
        //Declarar una cola de tipo string para almacenar los nombres de los clientes.
        //Permitir al usuario registrar (Enqueue) varios clientes en la cola.
        //Mostrar el estado actual de la cola.
        //Atender (Dequeue) al primer cliente y mostrar su nombre.
        //Mostrar la cola después de atender al cliente.
        //Indicar si la cola está vacía.


        static void Main(string[] args)
        {
            Queue<string> clientes = new Queue<string>();
            int opcion;

            do
            {
                Console.WriteLine("MENÚ");
                Console.WriteLine("1. Agregar cliente");
                Console.WriteLine("2. Mostrar registro de clientes");
                Console.WriteLine("3. Cliente atendido");
                Console.WriteLine("4. Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        // Agregar cliente
                        Console.Write("Ingrese el nombre del cliente: ");
                        string nombreCliente = Console.ReadLine();
                        clientes.Enqueue(nombreCliente);
                        Console.WriteLine($"{nombreCliente} agregado al listado de clientes.");
                        break;

                    case 2:
                        // Mostrar registro de los clientes
                        if (clientes.Count > 0 )
                        {
                            Console.WriteLine("El registro de los clientes ingresados es: ");
                            foreach (var c in clientes)
                            {
                                Console.WriteLine(c);
                            }
                        }
                        else
                        {
                            Console.WriteLine("El registro se encuentra vácio.");
                        }
                        break;

                    case 3:
                        // Cliente atendido, por lo tanto, eliminado del registro
                        if (clientes.Count > 0)
                        {
                            string clienteAtendido = clientes.Dequeue();
                            Console.WriteLine($"{clienteAtendido} fue atendido exitosamente.");

                            // Mostrar la cola después de atender al cliente
                            if (clientes.Count > 0)
                            {
                                Console.WriteLine("El registro de los clientes ingresados es: ");
                                foreach (var c in clientes)
                                {
                                    Console.WriteLine(c);
                                }
                            }
                            else
                            {
                                Console.WriteLine("El registro se encuentra vácio.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay clientes en el registro.");
                        }
                        break;

                    case 4:
                        // Salir
                        Console.WriteLine("Saliendo del programa...");
                        break;
                     
                    default:
                        Console.WriteLine("Opción inválida. Por favor, seleccione una opción del 1 al 4.");
                        break;
                }

            } while (opcion != 4); // Se cerrará cuando la opción sea 4
        }
    }
}
