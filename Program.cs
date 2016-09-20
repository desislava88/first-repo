using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = n;
            int sum = 0;
            do
            {
                int current = number % 10;
                sum += current;
                number /= 10;    
            } while (number != 0);
            Console.WriteLine("Sum is " + sum);
        }
    }
}
