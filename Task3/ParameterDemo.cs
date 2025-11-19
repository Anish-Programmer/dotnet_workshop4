using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class ParameterDemo
    {
       // Increase(ref int number) method
       public void Increase(ref int number)
       {
            number += 10; // increase the number by 10
       }

        // GetFullName(out string fullname) method
        public void GetFullName(out string fullName)
        {
            fullName = "Anish Tamang"; // assignig the full name to output parameter
        }

        // SumAll(params int[] numbers) method
        public int SumAll(params int[] numbers)
        {
            // defining sum variable
            int sum = 0;

            // using foreach loop to iterate
            foreach (var num in numbers)
            {
                sum += num;  // adding each number to sum
            }

            return sum;
        }

    }
}
