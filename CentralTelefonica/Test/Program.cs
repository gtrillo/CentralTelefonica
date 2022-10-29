using System;
using CentralTelefonica;
namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("Fede Center");

            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, 2.65f,"Rosario");
            Provincial l2 = new Provincial("Morón", Provincial.eFranja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, 1.99f , "San Rafael");
            Provincial l4 = new Provincial(Provincial.eFranja.Franja_3, l2);

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            c+=l1;
            Console.WriteLine(c.ToString());
            c+=l2;
            Console.WriteLine(c.ToString());
            c+=l3;
            Console.WriteLine(c.ToString());
            c+=l4;
            Console.WriteLine(c.ToString());

            

            Console.ReadKey();
        }
    }
}
