using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Calculator
    {
        // PrintWelcome() method
        public void PrintWelcome()
        {
            Console.WriteLine("Welcome to the Calculator!");
        }

        // Add() method
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }


        // Multiply() method
        public int Multiply(int num1, int num2=1)
        {
            return num1 * num2; ;
        }


    }
}
