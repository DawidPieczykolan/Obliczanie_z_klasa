using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa
{
    public class Karta
    {
        List<float> oceny;

        public void Dodajocene(float ocena) 
        {
            oceny.Add(ocena);
        }
        public float Obliczsrednia() 
        {
          return oceny.Average();
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
