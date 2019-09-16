using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public class Person
    {
        public string Name = "Kacper";
        public string LastName { get; set; }
        public int? Birthdate { get; set; }// musi byc wartosc

        public int GetAge()
        {
            return DateTime.Today.Year - (int)Birthdate;
        }

        //ctor tab tab
        public Person()
        {
            Birthdate = 1993;
            
        }
    }
}
