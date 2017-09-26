using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //What data types have we talked about?
            //An int is a whole number (no decimals)
            //A string is a collection of characters

            char firstInitial = 'D';
            //Characters or chars are single letters or numbers
            //or symbols

            bool isTired = true;
            //Boolean or bool is true or false
            //bool defaults to true

            //Other number data types
            float number = 2.1644033049072948493892837948f;
            decimal partialNum = 2.1644033049072948493892837948m;
            double someNumber = 2.1644033049072948493892837948;
            //double doesn't need the "d" at the end although you could put it

            Console.WriteLine(number);
            Console.WriteLine(partialNum);
            Console.WriteLine(someNumber);


        }
    }
}
