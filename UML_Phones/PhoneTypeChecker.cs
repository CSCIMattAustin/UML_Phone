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
            }   //if equal Nokia
        }
        public void checkProducts()
        {
            Console.WriteLine("The brand of your phone is {0}\n", manu);
            Console.WriteLine("The smart phone for {0} is {1}", manu, factory.getSmart().getName());
            Console.WriteLine("The not-so-smart phone for {0} is {1}\n", manu, factory.getDumb().getName());
        }
    }
}
