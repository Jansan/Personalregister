using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    class Personal
    {
        public string namn;
        public double lön;

        public void getPersonal(string _namn, double _lön)
        {
            this.namn = _namn;
            this.lön = _lön;
        }
    }
}
