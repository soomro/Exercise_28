using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_28
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a program that outputs the 3 first perfect numbers. 
            A perfect number is a number where all its positive divisors sums up to the actual number. 
            The first number is 28, where 14 + 7 + 4 + 2 + 1 = 28. 
            Tip: look at the previous exercise and build on top of it.
            */

            Console.WriteLine("Please enter the number you want to check:");
            int number = int.Parse(Console.ReadLine());
            int perfectNumberCount = 0;
            string PerfectNumbers_found = "";
            string allDivisibleNumbers = "";

            // catch 3 perfect number, check all.
            for (int j = number; number >= 1; j--)   // run 'number' times
            {
                int numberCopy = number;
                int sum;
                // iterate all values possible of numberCopy &
                for (int i = numberCopy; numberCopy >= 1; i--) // run 'number' times
                {
                    sum = 0;
                    // check modulo
                    int moduloResult = numberCopy % i;
                    // store modulo %
                    if (moduloResult == 0)
                    {
                        // concatinating all 'number's which result in modulo zero
                        allDivisibleNumbers = allDivisibleNumbers + " " + i.ToString();
                        sum += i;
                    }

                    // "perfect number" logic
                    // i.e.: if the sum of all modulo result of 'number' is equal to 'number'
                    if (sum == numberCopy || sum != 0)
                    {
                        perfectNumberCount++;
                        PerfectNumbers_found = PerfectNumbers_found + "  " + sum.ToString()  ;
                        Console.WriteLine("the first three perfect numbers are  {0}.", PerfectNumbers_found);
                    }
                    // printing perfect numbers, and ending the loop when necessary 3 perfect numbers found.
                    if (perfectNumberCount == 3)
                    {
                        Console.WriteLine("Stoping to check further, we found 3 perfect numbers!");
                        Console.WriteLine("Perfect numbers are:  {0}.", PerfectNumbers_found);
                        Console.ReadKey();
                        break;
                    }
                    else if ( i == numberCopy && perfectNumberCount == 3) {
                        Console.WriteLine("we found 3 perfect numbers!");
                        Console.WriteLine("Perfect numbers are:  {0}.", PerfectNumbers_found);
                        Console.ReadKey();
                        break;
                    }
                    // ending loop because not all three perfect numbers found.
                    else if (i == numberCopy && perfectNumberCount != 3)
                    {
                        Console.WriteLine("we couldn't found 3 perfect numbers!");
                        Console.WriteLine("Perfect numbers are:  {0}.", PerfectNumbers_found);
                        Console.ReadKey();
                        break;
                    }
                    Console.WriteLine("This is the result of all divisible numbers of {0} number-item(s) : {1}", number, allDivisibleNumbers);
                    numberCopy--;
                }
                number--;
            }
        }
    }
}
