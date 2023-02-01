using System;

namespace Ex2Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creare a 2 obiecte de tip autoturism
            Autoturism auto1 = new Autoturism("VW", "AB 33 ABC", 1400);
            Autoturism auto2 = new Autoturism("BMW", "CJ 12 XYZ", 1900);

            //Apelarea metodei de tiparire
            auto1.Tiparire();
            auto2.Tiparire();
        }
    }
}
