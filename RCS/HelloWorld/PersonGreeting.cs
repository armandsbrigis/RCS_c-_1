using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class PersonGreeting
    {
        public void SayHello()
        {
            string myName;
            myName = Console.ReadLine();
            Console.WriteLine("Sveika, Pasaule " + myName);

        }
    }
}
