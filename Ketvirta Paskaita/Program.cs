using System;

namespace KetvirtaPaskaita
{
    class Program
    {
        static void Main(string[] args)
      /*Sukurs sąrašą, kuriame yra šie sveikieji skaičiai: 5, 3, 8, 4, 2.*/
        {
         List<int> sveikejiSkaiciai = new List<int> { 5, 3, 8, 4, 2 };

            /* Išspausdins sąrašo elementus.
            {
                foreach (int skaiciusSarase in sveikejiSkaiciai)
                {
                    Console.WriteLine(skaiciusSarase);
                }

            }
            /* Pridės skaičių 10 į sąrašo pabaigą.
            sveikejiSkaiciai.Add(10);

            foreach (int skaiciusSarase in sveikejiSkaiciai)
            {
                Console.WriteLine(skaiciusSarase);
            }
            /*Ištrins skaičių 4 iš sąrašo*/

            sveikejiSkaiciai.Remove (4);

            foreach (int skaiciusSarase in sveikejiSkaiciai)
            {
                Console.WriteLine(skaiciusSarase);
            }

            /* Rūšiuos sąrašą didėjančia tvarka. */

           // sveikejiSkaiciai.Sort

            /* Išspausdins sąrašą po kiekvieno pakeitimo */

        }

    }
}