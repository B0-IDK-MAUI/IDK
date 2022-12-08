using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GcCollector
{
    internal class Program
    {
        public class MyClass
        {
            public static int Count = 0;
            public MyClass()
            {
                Count++;
                Console.WriteLine(Count);
            }
             ~MyClass()
            {
                Count--;
            }
        }

        static void Main(string[] args)
        {
            while(true)
            {
                MyClass myObj = new MyClass();
                
            }
        }
    }
}
