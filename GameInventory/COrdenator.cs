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

// Clase que representa un artículo en el inventario del juego medieval.
// Implementa la interfaz IInventario para mostrar información y la interfaz IComparable para permitir la comparación y ordenación por nivel.

namespace GameInventory
{
    internal class COrdenator : IInventario, IComparable<COrdenator>
    {
        private int Nivel;
        private string Objeto;
        private string Tipo;

        // Constructor
        public COrdenator(string pObjeto, string pTipo, int pNivel)
        {
            Nivel = pNivel;
            Objeto = pObjeto;
            Tipo = pTipo;
        }

        // Método para mostrar información del artículo
        public void MostrarInfo()
        {
            Console.WriteLine($"El nivel de {Objeto} de tipo {Tipo} es: {Nivel}");
        }

        // Sobrescritura del método ToString para facilitar la impresión
        public override string ToString()
        {
            return $"El nivel de {Objeto} de tipo {Tipo} es: {Nivel}";
        }

        // Método de comparación para la interfaz IComparable
        public int CompareTo(COrdenator other)
        {
            return Nivel.CompareTo(other.Nivel);
        }
    }
}
