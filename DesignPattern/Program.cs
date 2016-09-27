using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            House h1 = new TraditionalHouse();
            h1.TurnOnFireplace();

            House h2 = new ModernHouse();
            h2.TurnOffFireplace();
        }
    }
}
