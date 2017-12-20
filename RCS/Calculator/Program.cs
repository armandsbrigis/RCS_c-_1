using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //izveidot kalkulēšanas objektu
            Calculations calc;
            calc = new Calculations();

            //paprasīt lietotājam vērtību
            int firstNumber = calc.AskUserForNumber();
            // paprasīt otru vērtību
            int secondNumber = calc.AskUserForNumber();
            // saskaitīt 
            int result = firstNumber + secondNumber;
            Console.WriteLine(result);
            Console.ReadLine();




        }
    }
}
