/*Matthew Austin
 * 1/31/2017
 * File: Genie.cs
 * Purpose: returns the name of the phone "Genie"
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Phones
{
    class Genie : iDumb
    {
        public override string getName()
        {
            return "Genie";
        }
    }
}
