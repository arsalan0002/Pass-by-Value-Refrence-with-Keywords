using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REF_AND_OUT_KEYWORDS
{
    class Program
    {
        public static void PassByValue(int a)
        {
           a = a + 10;
           Console.WriteLine("Value is: {0}", a);
        }

//------------------------------------------------------------------------------------------------------------

        public static void PassByRef(ref int a)
        {
           a = a + 10;
           Console.WriteLine("Value is: {0}", a);
        }

//------------------------------------------------------------------------------------------------------------

        public static void PassByOut(out int a)
        {
            a = 20;
            Console.WriteLine("Value is: {0}", a);
        }

        static void Main(string[] args)
        {
            int value = 5
            PassByValue(value); // 15
            Console.WriteLine(value); // 5
            Console.ReadLine();

//------------------------------------------------------------------------------------------------------------

            int value = 5;
            PassByRef(ref value); // 15
            Console.WriteLine(value); // 15
            Console.ReadLine();

//------------------------------------------------------------------------------------------------------------

            int value;
            PassByOut(out value); // 20
            Console.WriteLine(value); // 20
            Console.ReadLine();

        }
    }
}
