using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetvirtaPaskaita
{
    class Studentai
        /* Sukurkite klasę Studentas su šiais laukais: vardas(string), amzius(int), balas(double). */
    {
        public string Name;
        public int Age;
        public double Mark; 
    

        public Studentai(string aName, int aAge, double aMark)
        {
            this.Name = aName;
           this.Age = aAge;
            this.Mark = aMark;

        }

        /* Sukurkite metodą, kuris grąžina studento informaciją kaip string */

    }
}
