/*Matthew Austin
 * 1/31/2017
 * File: Program.cs
 * Purpose: This is the main driver for the program
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneTypeChecker s = new PhoneTypeChecker(manufacturers.Samsung);
            PhoneTypeChecker n = new PhoneTypeChecker(manufacturers.Nokia);
            PhoneTypeChecker h = new PhoneTypeChecker(manufacturers.HTC);
            s.checkProducts();
            n.checkProducts();
            h.checkProducts();
            Console.ReadKey();
        }
    }
}
