/* Cree un programa que ordene los elementos del arreglo [9,15,1,14,8,7,6,5] 
en orden ascendente, muestre la suma y el promedio de todos sus elementos. */
using System;

namespace P3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0; double promedio=0;
            int[] numeros={9, 15, 1, 14, 8, 7, 6, 5};
            Array.Sort(numeros);
            Console.WriteLine("Array Ordenado:");
            for(int i=0; i<=7; i++)
            {
                Console.WriteLine(numeros[i]);
                sum+=numeros[i];
            }
            promedio=sum/numeros.Length;
            Console.WriteLine("Sumatoria de los Elemntos...:{0}", sum);
            Console.WriteLine("Promedio de los Elementos...:{0}", promedio);
        }
    }
}
