/* A = (2,4,6) y B = (1,3,5) PRODUCTO ESCALAR */

using System;

namespace P6
{
    class Program
    {
        static void Main(string[] args)
        {
            int escalar =0;
           int[] A= {2,4,6}, B={1,3,5};
            Console.WriteLine("---> PRODUCTO ESCALAR ENTRE DOS VECTORES <---");
           for( int i =0; i< A.Length; i++)
           {
               Console.Write(A[i]+" ");
           }
           
            Console.Write("\t\t");

              for( int i =0; i< B.Length; i++)
           {
               Console.Write(B[i]+" ");
           }

           for (int i=0; i<3; i++)
           {
               escalar=escalar +A[i] * B[i];
           }
           Console.WriteLine("\nEl producto escalas es...:" + escalar);
           Console.ReadKey();
        }
    }
}
