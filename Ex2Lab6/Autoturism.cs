using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2Lab6
{
   public class Autoturism
    {
        //Campuri care reprezinta caracteristicile unui autoturism
        private string marca;
        private string numarDeInmatriculare;
        private int capacitateCilindrica;

        //Constructorul
        public Autoturism (string marca, string numarDeInmatriculare, int capacitateCilindrica)
        {
            this.marca = marca;
            this.numarDeInmatriculare = numarDeInmatriculare;
            this.capacitateCilindrica = capacitateCilindrica;
        }

        //Metoda care arata printeaza caractersticile autoturismului
        public void Tiparire()
        {
            Console.WriteLine($"{marca}  {numarDeInmatriculare}  {capacitateCilindrica}");
        }
    }
}
