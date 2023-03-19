using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa
{
    public class Karta
    {
        List<float> oceny = new List<float>();

        public void DodajOcene(float ocena) 
        {
            oceny.Add(ocena);
        }

        //obliczanie średnej
        public float ObliczSrednia() 
        {
            float suma = 0;
            float srednia = 0;

            foreach (var ocena in oceny) 
            {
                suma += ocena;
            }
            srednia=suma / oceny.Count;
            return srednia;
        }
        public float NajniszaOcena() 
        {
            return oceny.Min();  
        }
        public float NajwyszaOcena() 
        {
        return  oceny.Max();
        }

    }
}
