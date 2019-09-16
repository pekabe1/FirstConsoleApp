using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public struct Person // referencja na stosie 
    {
        public string Name;
        public string LastName { get; set; }
        public int? Birthdate { get; set; }//  ? check for null

        public int GetAge()
        {
            return DateTime.Today.Year - (int)Birthdate;
        }

        //ctor tab tab
        //public Person()
        //{
        //    Birthdate = 1993;

        //}
    }
}
