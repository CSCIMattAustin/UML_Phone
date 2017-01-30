using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Phones
{
    class HTCFactory : iPhoneFactory
    {
        public override iSmart getSmart()
        {
            return new Titan();
        }
        public override iDumb getDumb()
        {
            return new Genie();
        }
    }
}
