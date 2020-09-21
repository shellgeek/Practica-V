/*Declare una variable llamada [notas] que permita guardar 4 notas, asígnele los valores 90,88,92
y 79 respectivamente.*/

using System;

namespace P2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] notas ={90, 88, 92, 79};

            for (int i=0; i<=3; i++)
            {
                Console.WriteLine(notas[i]);
            }
            
        }
    }
}
