using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int s;
            int n = 0;
            Console.WriteLine("Write a size of array: ");
            s = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[s];
            for (int i = 1; i <= s; i++)
            {
                Console.WriteLine("Write array elements from 1 to 100: ");
                numbers[n] = Convert.ToInt32(Console.ReadLine());
                if (numbers[n] >= 1 && numbers[n] <= 100)
                {
                    n++;
                }
                else
                {
                    Console.WriteLine("Array elements must be from 1 to 100!");
                    i--;
                }
                
            }

            Sum(numbers);
        }

        static void Sum(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                if (DivideCheck(number) == true)
                {
                    sum += number;
                }
            }
            Console.WriteLine(sum);
        }
        static bool DivideCheck(int number)
        {
            bool isDivisible;
            if (number % 5 == 0 && number % 3 == 0)
            {
                isDivisible = true;
            }
            else isDivisible = false;
            return isDivisible;
        }
    }
}
