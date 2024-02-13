using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Autor: Miguel Angel Arellano Juárez
 * Fecha: 12/02/2024
 * Versión: 1.0.0.0
 * Modificación: 12/02/2024
 */

namespace GameInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I N V E N T A R I O");

            // Crear una instancia de la clase CItems que contiene el inventario
            CItems inventario = new CItems();

            // Mostrar el inventario antes de ordenar
            foreach (COrdenator item in inventario)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------");

            // Preguntar al usuario si quiere ordenar el inventario por nivel
            Console.Write("¿Desea ordenar el inventario por nivel? (Sí/No): ");
            string respuesta = Console.ReadLine();

            if (respuesta.ToLower() == "sí" || respuesta.ToLower() == "si")
            {
                // Ordenar el inventario por nivel
                inventario.Sort();

                // Mostrar el inventario ordenado
                foreach (COrdenator item in inventario)
                {
                    Console.WriteLine(item);
                }
            }

            // Preguntar al usuario si desea comprar un artículo
            Console.Write("¿Cerrar inventario? (Sí/No): ");
            respuesta = Console.ReadLine();

            if (respuesta.ToLower() == "sí" || respuesta.ToLower() == "si")
            {
                Console.WriteLine("Cerrando . . .");
            }
        }
    }
}
