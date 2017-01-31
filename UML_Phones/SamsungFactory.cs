/*Matthew Austin
 * 1/31/2017
 * File: SamsungFactory.cs
 * Purpose: Factory for Samsung phones
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Phones
{
    class SamsungFactory : iPhoneFactory
    {
        public override iSmart getSmart()
        {
            return new GalaxyS2();
        }
        public override iDumb getDumb()
        {
            return new Primo();
        }

    }
}
