/*Matthew Austin
 * 1/31/2017
 * File: Lumia.cs
 * Purpose: returns a string with the name of the model
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Phones
{
    class Lumia : iSmart
    {
        public override string getName()
        {
            return "Lumia";
        }
    }
}
