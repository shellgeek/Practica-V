/*Cree un programa que permita almacenar en una sola variable la cantidad de números que
especifique el usuario. Luego permita que el usuario sea quien asigne esos valores. */

using System;
using System.Collections.Generic;

namespace P4
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> numeros = new List<int>();
           int cant;
           Console.Write("Ingrese la cantiad de Numeros que quiere Ingresar...:");
           cant =Convert.ToInt16(Console.ReadLine());
           for(int i=0; i<=cant; i++)
           {
               Console.Write("Ingrese el Elemento {0}...:",i);
               numeros.Add(Convert.ToInt16(Console.ReadLine()));
           }

           Console.Write("Los Elementos del Array son...:");
           for(int i=0;i<=cant; i++)
           {
               Console.Write(numeros[i] + " ");
           }
           Console.ReadKey();
        }
    }
}
