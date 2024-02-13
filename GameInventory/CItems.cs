using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    internal class CItems : IEnumerable<COrdenator>
    {
        private List<COrdenator> slots;

        // Constructor
        public CItems()
        {
            slots = new List<COrdenator>
            {
                // Inicialización del inventario con algunos artículos
                new COrdenator("Espada", "Arma", 1),
                new COrdenator("Peto de Hierro", "Equipamiento", 4),
                new COrdenator("Lingote de Hierro", "Recurso", 5),
                new COrdenator("Lingote de Oro", "Recurso", 5),
                new COrdenator("Hacha de batalla", "Arma", 7),
                new COrdenator("Casco de hierro", "Equipamiento", 9),
                new COrdenator("Cota de malla", "Equipamiento", 1),
                new COrdenator("Manzana", "Comida", 2),
                new COrdenator("Carne", "Comida", 4),
                new COrdenator("Pala", "Herramienta", 6)
            };
        }

        // Método para obtener un enumerador del inventario
        public IEnumerator<COrdenator> GetEnumerator()
        {
            return slots.GetEnumerator();
        }

        // Método para ordenar el inventario
        public void Sort()
        {
            slots.Sort();
        }

        // Implementación del enumerador no genérico requerido por IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
