using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class House
    {
        private bool _isOpen;
        protected IFireplaceBehaviour fireplaceBehaviour;


        public bool OpenDoor()
        {
            if (_isOpen)
                return false;
            else
                _isOpen = true;

            return true;
        }

        public void TurnOnFireplace()
        {
            fireplaceBehaviour.TurnOnFireplace();
        }

        public void TurnOffFireplace()
        {
            fireplaceBehaviour.TurnOffFireplace();
        }

    }
}
