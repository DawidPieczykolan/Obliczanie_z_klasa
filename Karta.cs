using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa
{
    public class Karta
    {
<<<<<<< HEAD

=======
<<<<<<< HEAD
>>>>>>> bb69ad9705ca8f2e5f7312d2bb2c25490dc653eb
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
<<<<<<< HEAD
            srednia = suma / oceny.Count;
            return srednia;    
=======
            srednia=suma / oceny.Count;
            return srednia;
=======
        List<float> oceny;

        public void Dodajocene(float ocena) 
        {
            oceny.Add(ocena);
        }
        public float Obliczsrednia() 
        {
          return oceny.Average();
>>>>>>> 36549db0d80ce7f755308b95b21fe79d24dea8ec
>>>>>>> bb69ad9705ca8f2e5f7312d2bb2c25490dc653eb
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
