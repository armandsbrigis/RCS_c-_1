using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarter_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            //izveidosim tātad eeemmmmm, kalkulatora objektu

            //paprasit lieotājam ievadīt 
            Console.WriteLine("please ender a job");
            string input = Console.ReadLine();
            int result;
            int counter = 0;
            while (counter < input.Lenght)
            {

                char symbol = input[counter];
                if(symbol == '+')
                {
                    Console.WriteLine("plus");
                }
                else
                {
                    int number;
                    number = Int32.Parse(symbol.ToString());
                    Console.WriteLine("number" + number);
                }
                counter = counter + 1;
            }
            Console.ReadLine();






        }
    }
}
