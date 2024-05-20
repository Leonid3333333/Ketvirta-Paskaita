using System;
using System.ComponentModel.Design;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace KetvirtaPaskaita
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Užduotis 3: Ciklai ir Sąlygos Sakiai Aprašymas Sukurkite programą, kuri atliks šias užduotis:
                  1.Sugeneruos sveikųjų skaičių sąrašą nuo 1 iki 100.
                 2. Naudos ciklą, kad patikrintų kiekvieną skaičių ir išspausdins "Fizz", jei skaičius dalijasi iš 3,
                  "Buzz", jei dalijasi iš 5, ir "FizzBuzz", jei dalijasi ir iš 3, ir iš 5.
                  Jei nei viena iš šių sąlygų netinka, išspausdins patį skaičių. */

            Random random = new Random();
            random.Next(1, 100);

            List<int> list = new List<int>();

           
           for (int i = 0; i < 100; i++)
            {
             int kintamasis = random.Next(1, 100);
               list.Add(kintamasis);
            Console.WriteLine(kintamasis);
            }
          

        }
    }
}