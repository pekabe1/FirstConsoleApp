using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Program
    {




        static void Main(string[] args)
        {
            //bool isTrue = true;
            int a = 10;
            Console.WriteLine("hello world");
            Console.WriteLine(a * 2);

            a++; // najpier wyswietl potem zwieksz
            a--;
            --a;// zwieksz i wyswietl
            ++a;
            // konwetowanie z miejszej na wieksza dziala zawsze
            double c = (int)a;
            c = int.Parse(c.ToString());

            // klasa nadrzedna to klasa object
            //ctrl + k + c komentowanie
            // ctrl + k + u uncomment
            // ctrl + k + d clean up code
            //  w przypadku obliczen int + decimal uzwyamy
            // nawiasy to wywałanie konstruktora

            // TYPY REFERENCYJNE trafiaja na sterte a zmienne na stos
            //ctr + . podpowiedzi


            Person andrzej = new Person
            {
                LastName = "Andrziej",
                Birthdate = 1993

            };
            Console.WriteLine(andrzej.Name + " " + andrzej.LastName);
            Console.WriteLine(andrzej.GetAge());


            Person anna = andrzej;

            Console.WriteLine(anna.LastName);
            Console.WriteLine(anna.Name);

            int cc = 10;
            int dd = cc;
            dd = 5;
            Console.WriteLine(dd + " " + cc);
            var michau = andrzej;
            var x = 45;
            dynamic xd = 0;
            xd = "Imie";

            int[] elemnts = { 1, 2, 3, 4, 5, 6, 6, 7, 7, 0 };
            foreach (var item in elemnts)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();



            if (cc != 0)
            {
                Console.WriteLine(" cc is not zero");
            }
            else if (cc == 10)
            {
                Console.WriteLine("cc 10");


            }
            else
                Console.WriteLine("cc <> 0");

            string s = "Roman";
                string z = s;
            // string ma referencje do innego obiektu








        }





    }
}
