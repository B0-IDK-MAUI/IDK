using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialTestConsoleApp
{
    public class Program
    {
        public static void Test1()
        {
            Console.WriteLine("Input:");
            List<string> lista = new List<string>();
            for (int i = 0; i < 3; i++)
                lista.Add(Console.ReadLine());

            lista.Reverse();
            Console.WriteLine("Reversed:");
            for(int i = 0; i< lista.Count;i++)
                Console.Write($"{lista[i]}");
        }

        public static void Test2()
        {
            int num = 0;
            int w = 0;
            num = Convert.ToInt32(Console.ReadLine());
            w = Convert.ToInt32(Console.ReadLine());
            while (w != 0)
            {
                for (int i = 0; i < w; i++)
                {
                    for (int j = 0; j < w; j++)
                    {
                        Console.Write(num);

                    }
                    w--;
                    Console.WriteLine();
                }
            }

        }

        public static void Test3()
        {
            string usrid = "", pw = "";
            string secretid = "keksz";
            string secretpw = "tekercs";
            int attempt = 0;
            bool hit = false;
            while (attempt != 3)
            {
                Console.WriteLine(attempt + 1 + ". attempt");
                Console.Write("Username: ");
                usrid = Console.ReadLine();
                Console.Write("Password: ");
                pw = Console.ReadLine();
                attempt++;
                if (usrid == secretid && pw == secretpw)
                {
                    hit = true;
                    break;
                }
                hit = false;

            }
            if(hit)
                Console.WriteLine("Login succeded");
            else
                Console.WriteLine("Banned");                    

        }

        public static void Test11()
        {
            int dec = 0;
            Console.Write("Decimal: ");
            dec = Convert.ToInt32(Console.ReadLine());

            Console.Write("Binary: " + Convert.ToString(dec,2));

        }

        static void Main(string[] args)
        {
            //Test1();
            //Test2();
            //Test3();
            Test11();
            Console.ReadKey();    
        }
    }
}
