/* Cree una clase Base llamada Padre con un método llamado ShowMessage 
que muestre en pantalla “Hola desde la clase padre” . Cree otra clase llamada Hija,
 y permita que el método ShowMessage muestre el mensaje “Hola desde la clase Hija.*/

using System;

namespace P1
{
   public class Program
    {
        static void Main(string[] args)
        {
            Hija son = new Hija();
            son.ShowMessaje("Hola Desde la clase Hija");
            Console.Write("El Mensaje Es...: "+ Hija.mensaje);
        }
    }
}

