// See https://aka.ms/new-console-template for more information
using System;

namespace OperatorExercise
{
    class Program
    {
        //Add
        //Given two integers, add them
        //PARAMS: two operands
        //RETURNS: sum of the operands
        public static int Add(int a, int b)
        {
            return (a + b);
        }
        //Add
        //Given two integers, subtract one from the other
        //PARAMS: two operands (a and b)
        //RETURNS: difference (a-b)
        public static int Subtract(int a, int b)
        {
            return (a - b);
        }
        //Add
        //Given two integers, return the two multiplied together 
        //PARAMS: two factors
        //RETURNS: product (a*b) 
        public static int Multiply(int a, int b)
        {
            return (a * b);

        }
        //Add
        //Given two integers, divide one by the other
        // Print out the quotient and remainder
        //PARAMS: two operands (a and b)
        //RETURNS: Nothing
        public static void Divide(int a, int b)
        {
            int quotient;
            int remainder = (a % b);

            //Avoid the division by zero problem:
            if (b != 0)
                quotient = (a / b);
            else
                quotient = 0;
            //Print the results:
            Console.WriteLine("{0}/{1} is {2} remainder {3}", a, b, quotient, remainder);
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            Divide(17, 4);
            // Have a bunch of random #s to test the function:
            for (long i = 0; i < 10; i++)
                Divide(rnd.Next(50, 100), rnd.Next(1, 50));

        }
    }
}

