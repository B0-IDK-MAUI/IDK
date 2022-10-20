using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Feladatok10_20
{
    internal class Program
    {

        static List<int> szamlista = new List<int>() { 8,37,11,98,95,43,11,98,8,8,37};

        static List<string> szolista = new List<string>() {"fa1","kép","daru","fa3","alma","doboz1","kép","doboz2","fa2"};

        public static void Nagyobb20()
        {
            foreach(var item in szamlista)
            {
                if(item > 20)
                    Console.Write(item + ",");
            }
        }

        public static void Hanyszor()
        {
            szamlista.Sort();

            List<int> seged = new List<int>();

            seged = szamlista.Distinct().ToList();
       
            int count = 0;
            for(int i = 0; i< seged.Count;i++)
            {
                count = 0;
                for (int j = 0; j < szamlista.Count; j++)
                {
                    if (szamlista[j] == seged[i])
                    {
                        count++;
                    }                   
                }
                Console.WriteLine($"{seged[i]} --> {count} db van");
            } 
        }

        public static void GyakoriKezdo()
        {

            szolista.Sort();

            for (int i = 0; i < szolista.Count; i++)
                Console.WriteLine($"{szolista[i]} ||");


            List<char> starters = new List<char>();

            for (int i = 0; i < szolista.Count; i++)
                starters.Add(szolista[i][0]);

            int count = 0;

            starters = starters.Distinct().ToList();

            Dictionary<char,int> help = new Dictionary<char,int>();

            for (int i = 0; i < starters.Count; i++)
            {
                count = 0;
                for (int j = 0; j < szolista.Count; j++)
                {
                    if (szolista[j][0] == starters[i])
                    {
                        count++;
                    }
                }
                help.Add(starters[i],count);
            }

            
            help.ToList().ForEach(x => Console.WriteLine("key:" + x.Key + ",value:" + x.Value)) ;
            int max = 0;
            foreach(var item in help)
            {
                if(item.Value > max)
                {
                    max = item.Value;
                }
            }
            foreach (var item in help)
            {
                if (item.Value == max)
                {
                    for(int i = 0; i < szolista.Count;i++)
                    {
                        if (szolista[i][0] == item.Key)
                            szolista.Remove(szolista[i]);
                    }
                    for (int i = 0; i < szolista.Count; i++)
                    {
                        if (szolista[i][0] == item.Key)
                            szolista.Remove(szolista[i]);
                    }
                }
            }

            Console.WriteLine("Gyakori kezdők törölve, új szólista");

            foreach(var item in szolista)
                Console.Write(item + "||");




        }

        public static void AtlagnalKisebb()
        {
            foreach(var item in szamlista)
            {
                if (item < szamlista.Average())
                    Console.Write(item + ",");     
            }
        }

        public static void GondoltamEgySzamra()
        {
            Random r = new Random();

            int gep = r.Next(0, 21);
            Console.Write("Kérem a tippet:");
            int input = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (input > gep) Console.WriteLine("Kisebb");
                if (input < gep) Console.WriteLine("Nagyobb");
                Console.Write("Kérem a tippet:");
                input = Convert.ToInt32(Console.ReadLine());
            } while (gep != input);
            Console.WriteLine("Talált!");

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Nagyobb 20:");
            Nagyobb20();
            Console.WriteLine();
            Console.WriteLine("Hanyszor ismetlodik:");
            Hanyszor();
            Console.WriteLine();
            Console.WriteLine("Leggyakoribb kezdő:");
            GyakoriKezdo();
            Console.WriteLine();
            Console.WriteLine("Atlagnal kisebb: ");
            AtlagnalKisebb();
            Console.WriteLine();
            Console.WriteLine("Gondoltam egy szamra:");
            GondoltamEgySzamra();

            Console.ReadKey();
        }
    }
}
