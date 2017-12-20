using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculations
    {
        public int AskUserForNumber()
        {
            //izvadīt tekstu, kas paprasa ciparu
            Console.WriteLine("please enter number");
            //ielasīt ciparu no konsoles
            //izveido mainigo kas glaba tekstu
            int number;
            string inputText = Console.ReadLine();
            //pārveido lielotāja tekstu par ciparu
            bool success = Int32.TryParse(inputText, out number);

            //int 32 ir klases ar funkcijām

            if (success == false)
            {
                Console.WriteLine("Sorry, you are stupid");
                number = AskUserForNumber();

            }

            return number;
        }

    }

}
