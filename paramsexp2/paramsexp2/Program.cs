using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace paramsexp2
{
    public class Overload
    {
        public void Display()
        {
            int[] numbers = { 10, 20, 30 };
            DisplayOverload(40, numbers);
            Console.WriteLine(numbers[1]);
        }

        private void DisplayOverload(int a, params int[] parameterArray)
        {
            parameterArray[1] = 1000;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Overload overload = new Overload();
            overload.Display();
            Console.ReadKey();
        }
    }
}
