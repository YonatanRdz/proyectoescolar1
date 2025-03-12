using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicafinal
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Creación e inicialización del arreglo
            // Se define un arreglo de enteros con 10 elementos y se inicializa con los valores del 1 al 10
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Se imprime el arreglo inicial
            Console.WriteLine("Arreglo inicial:");
            ImprimirArreglo(numeros);

            // 2. Modificación de un elemento
            // Se cambia el valor del tercer elemento (índice 2) por 99
            numeros[2] = 99;

            // Se imprime el arreglo después de la modificación
            Console.WriteLine("\nArreglo después de modificar el tercer elemento:");
            ImprimirArreglo(numeros);

            // 3. Suma de los elementos del arreglo
            // Se inicializa una variable para almacenar la suma
            int suma = 0;

            // Se recorre el arreglo sumando cada elemento a la variable suma
            foreach (int num in numeros)
            {
                suma += num;
            }

            // Se imprime la suma de los elementos del arreglo
            Console.WriteLine("\nLa suma de los elementos del arreglo es: " + suma);

            // 4. Búsqueda de un número en el arreglo
            // Se define el número a buscar
            int numeroBuscado = 78;

            // Se usa Array.IndexOf para encontrar el índice del número buscado
            int indice = Array.IndexOf(numeros, numeroBuscado);

            // Se verifica si el número fue encontrado
            if (indice != -1)
            {
                // Se imprime el índice en el que se encontró el número
                Console.WriteLine("\nEl número " + numeroBuscado + " se encuentra en el índice: " + indice);
            }
            else
            {
                // Se imprime un mensaje si el número no fue encontrado
                Console.WriteLine("\nElemento no encontrado");
            }
        }

        // Método para imprimir los elementos de un arreglo
        static void ImprimirArreglo(int[] arreglo)
        {
            // Se recorre el arreglo e imprime cada elemento separado por un espacio
            foreach (int num in arreglo)
            {
                Console.Write(num + " ");
            }
            // Se imprime una línea en blanco para mejorar la presentación en consola
            Console.WriteLine();
        }
    }
}
