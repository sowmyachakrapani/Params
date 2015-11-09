using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paramsexpproject
{

    public class Overload
    {
        public void Display()
        {
            int number = 102;
            DisplayOverload(200, 1000, number, 200);
            Console.WriteLine(number);
        }

        private void DisplayOverload(int a, params int[] parameterArray)
        {
            parameterArray[1] = 3000;
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Overload overload = new Overload();
            overload.Display();//102 is displayed number value is not changed.
            Console.ReadKey();
        }
    }
}
