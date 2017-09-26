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
            float number = 2.1644033049072948493892837948123456789f;
            decimal partialNum = 2.1644033049072948493892837948123456789m;
            double someNumber = 2.1644033049072948493892837948123456789;
            //double doesn't need the "d" at the end although you could put it

            Console.WriteLine(number);
            Console.WriteLine(partialNum);
            Console.WriteLine(someNumber);

            //Now let's talk about operators!
            // ARITHMETIC OPERATORS
            // + adds two operands
            // - subtracts the second operand from the first
            // * Multiples both operands
            // / Divides first operand by second operand
            // % Modulus divides and checks remainder
            // ++ Increments operator by one and is used for ints
            // -- Decrements, decreases value by one
            // RELATIONAL OPERATORS
            // == Checks if the values of two operands are equal
            // and if they are, returns bool true
            // != (Bang) Checks if values of two operands are equal or
            // not, and if values are NOT equal, returns
            // bool true.

            int jarryAge = 29;
            int danielAge = 32;
            Console.WriteLine(jarryAge == danielAge);

            /*
             * > Checks if ther value of the left operand is
             * greater than the value of the right operand, and
             * if yes then the condition is true
             * 
             * < Checks if the value of the left operand is
             * less than the value of the right operand, and
             * if yes then condition is true
             * 
             * >= Checks if the value of left operand is greater
             * than or equal to the value of the right operand,
             * and if yes then the condition becomes true.
             * 
             * <= Checks if the value of the left operand is
             * less than or equal to the value of the right operand
             * and if yes than condition becomes true
             
            // LOGICAL OPERATORS
            /*
             * && we call AND operator. If both the operands are
             * non zero then condition becomes true.
             * 
             * || we call OR operator. If any of the two operands
             * is non zero then condition becomes true.
             * 
             * ! we call NOT operator. This is used to reverse
             * the logical state of the operand. If the condition is
             * true then Logical NOT operator will make false
             * 
             * 
                
        }
    }
}
