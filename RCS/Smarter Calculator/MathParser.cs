using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarter_Calculator
{
    class MathParser
    {
        //funkcija kas saņem lietotāja ievadītu tekstu
        //un saparsē to, veic matemātiskās darbības
        //un atgriežas rezultātu
        public int ParseMath(string input)
        {
            int result;
            //
            string firstEnteredNumber = "";
            string secondEnteredNumber = "";
            char enteredOperation = ' ';
            bool operationFound = false;
            int counter = 0;
            while (counter < input.Length)
            {

                char symbol = input[counter];
                if (symbol == '+')
                {
                    //saglabā operāciju mainīgā
                    //ieliek karodziņu, ka kad tiks pabeigts
                    //ielasīt nākošo skaitli, operācija jāizpilda
                    operationFound = true;
                }
                else
                {
                    if (operationFound == false)
                    {


                    }
                    firstEnteredNumber = firstEnteredNumber + symbol;
                }
                counter = counter + 1;
            }
        }

    }
}
