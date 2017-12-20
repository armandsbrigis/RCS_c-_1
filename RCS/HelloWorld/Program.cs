using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonGreeting greet;
            greet = new PersonGreeting();
            greet.HelloText = "Hello world";
            greet.SayHello();

            PersonGreeting seaGreet;
            greet = new PersonGreeting();
            greet.HelloText = "Ahoy, world";
            greet.SayHello();

            Console.ReadLine();
        
        }
    }
}
