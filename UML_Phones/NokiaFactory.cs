/*Matthew Austin
 * 1/31/2017
 * File: NokiaFactory.cs
 * Purpose: factory for the Nokia phones
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Phones
{
    class NokiaFactory : iPhoneFactory
    {
        public override iSmart getSmart()
        {
            return new Lumia();
        }
        public override iDumb getDumb()
        {
            return new Asha();
        }
    }
}
