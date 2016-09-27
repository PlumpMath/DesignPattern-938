using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class ElectricFireplace : IFireplaceBehaviour
    {
        public bool TurnOffFireplace()
        {
            Console.WriteLine("Turn off electric fireplace");
            return true;
        }

        public bool TurnOnFireplace()
        {
            Console.WriteLine("Turn on electric fireplace");
            return true;
        }
    }
}
