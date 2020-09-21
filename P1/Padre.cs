using System;
namespace P1
{
    public class Padre
    {
        public static string nombre;
        public static string apellido;
        public static string mensaje;

        public Padre()
        {
            nombre="RAMON";
            apellido="MENDEZ";
            mensaje ="HOLA, SOY EL PADRE";
        }
    public string ShowMessaje(string mensaje)
    {
        mensaje="Hola desde la clase padre!";
        return mensaje;
    }
    }
}