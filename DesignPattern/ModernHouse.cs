using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class ModernHouse : House
    {
        public ModernHouse()
        {
            fireplaceBehaviour = new ElectricFireplace();
        }
    }
}
