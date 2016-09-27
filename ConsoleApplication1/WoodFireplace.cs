using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class WoodFireplace : IFireplaceBehaviour
    {
        public bool TurnOffFireplace()
        {
            Console.WriteLine("Turn off wood-burning fireplace");
            return true;
        }

        public bool TurnOnFireplace()
        {
            Console.WriteLine("Turn on wood-burning fireplace");
            return true;
        }
    }
}
