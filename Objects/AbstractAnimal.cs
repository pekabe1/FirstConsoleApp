using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public abstract class AbstractAnimal
    {
        string Name { get; set; } // metody w interface nie moge byc prywatne
        int GetLegs();

    }
}
