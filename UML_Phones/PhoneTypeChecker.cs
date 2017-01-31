/*Matthew Austin
 * 1/31/2017
 * File: PhoneTypeChecker.cs
 * Purpose: creates a new factory based on the manufacturer passed in and prints out the stats for each model
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
       
namespace UML_Phones
{
    class PhoneTypeChecker
    {
        iPhoneFactory factory;
        manufacturers manu;
        public PhoneTypeChecker (manufacturers m)
        {
            manu = m; 
            if(m.Equals(manufacturers.Samsung))
            {
                factory = new SamsungFactory();
            }
            else if(m.Equals(manufacturers.HTC))
            {
                factory = new HTCFactory();
            }
            else if(m.Equals(manufacturers.Nokia))
            {
                factory = new NokiaFactory();
            } 
        }
        public void checkProducts()
        {
            Console.WriteLine("The brand is {0}", manu);
            Console.WriteLine("The smart phone for {0} is {1}", manu, factory.getSmart().getName());
            Console.WriteLine("The not-so-smart phone for {0} is {1}\n", manu, factory.getDumb().getName());
        }
    }
}
