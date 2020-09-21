/*  A = (2,4,6) y B = (1,3,5)*/

using System;

namespace P5
{
    class Program
    {
        static void Main(string[] args)
        {
           
           int[] A= {2,4,6}, B={1,3,5}, R={0,0,0};
            Console.Clear();
            Console.WriteLine("---> PRODUCTO VECTORIAL ENTRE DOS VECTORES <---");
           for( int i =0; i< A.Length; i++)
           {
               Console.Write(A[i]+" ");
           }
           
            Console.Write("\t\t");

              for( int i =0; i< B.Length; i++)
           {
               Console.Write(B[i]+" ");
           }

            R[0]=A[1]*B[2] - A[2]*B[1];
            R[1]=A[2]*B[0] - A[0]*B[2];
            R[2]=A[0]*B[1] - A[1]*B[0];
           Console.Write("\nEl producto escalas es...:");
           for(int i =0; i<=2; i++)
           {
               Console.Write(R[i]+" ");
           }
           Console.ReadKey();
        }

        }
    }

