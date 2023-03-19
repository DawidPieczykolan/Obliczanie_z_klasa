using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa
{
    internal class Program
    {
<<<<<<< HEAD
        

        static void Main(string[] args)
        {
            Karta karta=new Karta();
            Karta kartaUser = new Karta();


            //przykladowe dane
        
            karta.DodajOcene(3);
            karta.DodajOcene(4);
            karta.DodajOcene(6);
            karta.DodajOcene(1);
           

            float srednia=karta.ObliczSrednia();
            float min = karta.NajniszaOcena();
            float max = karta.NajwyszaOcena();


            for (; ; )
            {
                Console.WriteLine( "Podaj liczbę w przediale 1-6" );
                float ocena;
                bool wynik=float.TryParse(Console.ReadLine(), out ocena); 
                if (wynik)
                {
                    if (ocena == 10)
                    {
                        break;   
                    }
                    if (ocena > 0 && ocena <= 6 )
                    {
                     kartaUser.DodajOcene(ocena);
                    }
                    else 
                    {
                        Console.WriteLine( "Podaj liczbę od 1-6" );
                    }
                }
                else 
                {
                    Console.WriteLine( "To nie jest liczba proszę podać livzbę od 1-6" );
                }



                Console.WriteLine( "Najwysza ocena " + kartaUser.NajwyszaOcena());
                Console.WriteLine(  "Najnisza ocena " + kartaUser.NajniszaOcena());
                Console.WriteLine( "Najwysza ocena " + kartaUser.ObliczSrednia());


                Console.ReadKey();
            }

=======
        static void Main(string[] args)
        {
>>>>>>> 36549db0d80ce7f755308b95b21fe79d24dea8ec
        }
    }
}
