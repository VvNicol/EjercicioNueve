using System.Collections;

namespace edu.ejercicio.nueve.nrojlla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un array de números enteros del 1 al 8
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8 };

            // Crear un ArrayList con las provincias de Andalucía
            ArrayList provinciasAndalucia = new ArrayList()
            {
             "Almería", "Cádiz", "Córdoba", "Sevilla" ,"Granada", "Huelva", "Jaén", "Málaga"
            };

            provinciasAndalucia.Sort();

            provinciasAndalucia.Insert(0, numeros[0]);
        
            for(int i = 1; i < numeros.Length; i++)
            {
                provinciasAndalucia.Insert(i * 2, numeros[i]);
            }

            foreach(var andalucia  in provinciasAndalucia)
            {
                Console.WriteLine(andalucia);
            }

        }
    }
}
