using System;
using System.Security.Cryptography.X509Certificates;

namespace KetvirtaPaskaita
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Sukurkite kelis studentų objektus ir pridėkite juos į sąrašą.
              Sukurkite metodą, kuris grąžina studento informaciją kaip string */

            List<Studentai> studentai = new List<Studentai>();

            Studentai studentas1 = new Studentai("Petras", 18, 9);
            Studentai studentas2 = new Studentai("Jonas", 26, 8);

            studentai.Add(studentas1);
            studentai.Add(studentas2);

            // (Console.WriteLine(studentas1);    
            /* Išspausdinkite visų studentų informaciją.*/

            foreach (Studentai Studentas in studentai) 
            {
                for (int i = 0; i < studentai.Count; i++)
                {
                    Console.WriteLine(Studentas.Name + " " + Studentas.Age + " " + Studentas.Mark);
                    
                }
            }
            Console.WriteLine();

        }

    }
}