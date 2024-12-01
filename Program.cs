using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_and_number_of_even_and_odd_numbers_in_the_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Start value: ");
            if (!int.TryParse(Console.ReadLine(), out int startValue))
            {
                Console.WriteLine("\nInvalid number");
                return ;
            }
            else
            {
                Console.Write("End value: ");
                if (!int.TryParse(Console.ReadLine(), out int endValue))
                {
                    Console.WriteLine("\nInvalid number");
                    return ;
                }
                else if (endValue < startValue)
                {
                    Console.WriteLine("\nYour range is impossible");
                    return ;
                }
                else
                {
                    int countOdd = 0;
                    int countEven = 0;

                    while (startValue <= endValue)
                    {
                        if (startValue % 2 == 0)
                            countEven += startValue;
                        else if (startValue % 2 == 1)
                            countOdd += startValue;
                        else
                        {
                            Console.WriteLine("\nFatal error");
                            return ;
                        }
                        startValue++;
                    }

                    Console.WriteLine("\nIn your range sum of even numbers: " + countEven);
                    Console.WriteLine("In your range sum of odd numbers: " + countOdd);
                }
            }
        }
    }
}
