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
        public IFireplaceBehaviour FireplaceBehaviour { get; set; }


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
            FireplaceBehaviour.TurnOnFireplace();
        }

        public void TurnOffFireplace()
        {
            FireplaceBehaviour.TurnOffFireplace();
        }

    }
}
