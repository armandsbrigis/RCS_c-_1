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

            MathParser parser;

            parser = new MathParser();

            
            //paprasit lieotājam ievadīt 

        
            Console.WriteLine("please ender a job");

            string input = Console.ReadLine();

            //izsauc aprēķināšanas funkciju un saglabāt rezultātu

           int result = parser.ParseMath(input);

            //izvada rezultātu uz ekrāna

            Console.WriteLine("your result" + result);
           
            Console.ReadLine();






        }
    }
}
