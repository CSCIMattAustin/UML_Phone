using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Phones
{
    abstract class iPhoneFactory
    {
        public abstract iSmart getSmart();
        public abstract iDumb getDumb();
    }
}
