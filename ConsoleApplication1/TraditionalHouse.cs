using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class TraditionalHouse : House
    {
        public TraditionalHouse()
        {
            fireplaceBehaviour = new WoodFireplace();
        }
    }
}
