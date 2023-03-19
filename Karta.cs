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
            srednia = suma / oceny.Count;
            return srednia;    
        }
        //dodawanie ocenny 
        public void Dodajocene(float ocena) 
        {
            oceny.Add(ocena);
        }
        // Średnia 
        public float Obliczsrednia() 
        {
          return oceny.Average();

        }
        // Najnisza Ocena
        public float NajniszaOcena() 
        {
            return oceny.Min();  
        }
        // Najwieksza Ocena
        public float NajwyszaOcena() 
        {
        return  oceny.Max();
        }

        //oblicznie Satystyki
        internal kartaSatystyki obliczSatystyki()
        {
            throw new NotImplementedException();
        }
    }
}
