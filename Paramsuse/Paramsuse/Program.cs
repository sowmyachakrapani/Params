using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paramsuse
{
    class Program
    {
        static void Main(string[] args)
        {
            Addnumbers(10, 20);
            Addnumbers(10, 20, 30, 40, 50);//to insert code snippet we have to right click on this page select code snippet then c# and then construct.
   
                    
        }
        //*first way
        //public static void Addnumbers(int fn, int sn)
        //{
        //    Addnumbers(10, 20,null);
        //}
        //*second way
        public static void Addnumbers(int fn, int sn, params object[] numbers)
        {
            int result = fn + sn;
            if (numbers != null)
            {
                foreach(int num in numbers)
                {
                    result = result + num;
                }
            }
            Console.WriteLine("Sum is = " + result);
        }
    
    }
}
