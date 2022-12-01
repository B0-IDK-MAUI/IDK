using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;

namespace Jsonreader
{
    public class JsonType
    {
        string nev;
        public int fizetes;

        public JsonType(string nev,int fizetes)
        {
            this.nev = nev;
            this.fizetes = fizetes;
        }
    }

    internal class Program
    {
        public static void Beolvas()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string[] tmp = File.ReadAllLines("szoveges.txt");
            sw.Stop();
            Console.WriteLine("Idő: " + sw.ElapsedMilliseconds);
        }

        public static void JSONBeolvas()
        {
            Stopwatch sw = new Stopwatch();
            sw.Reset();
            sw.Start();
            string[] tmp = File.ReadAllLines("proba.json");
            sw.Stop();
            Console.WriteLine("Json Idő: " + sw.ElapsedMilliseconds);
        }



        public static void Ment()
        {
            string[] tmp = File.ReadAllLines("szoveges.txt");

            Stopwatch sw = new Stopwatch();
            sw.Start();
            File.WriteAllLines("ment.txt", tmp);
            sw.Stop();
            Console.WriteLine("Idő: " + sw.ElapsedMilliseconds);
        }

        public static void JsonMent()
        {
            string tmp = File.ReadAllText("proba.json");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            
            var hehe = JsonConvert.DeserializeObject<JsonType>(tmp);
            sw.Stop();
            Console.WriteLine("Idő: " + sw.ElapsedMilliseconds);
        }

        public static void Update()
        {
            Random r = new Random();
            Stopwatch stw = new Stopwatch();
            stw.Start();
            FileStream f = new FileStream("szoveges.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(f);
            for (int i = 0; i < 100000; i++)
                sw.WriteLine(r.Next(200000, 5000000));
            sw.Close(); f.Close();
            stw.Stop();
            Console.WriteLine("Feltöltve! " + stw.ElapsedMilliseconds);
        }

        public static void  SzovegesGeneralas()
        {
            Random r = new Random();
            FileStream f = new FileStream("szoveges.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(f);
            for (int i = 0; i < 100000; i++)
                sw.WriteLine(r.Next(200000, 5000000));
            sw.Close(); f.Close();

            List<JsonType> lista = new List<JsonType>();

            for (int i = 0; i < 10; i++)
                lista.Add(new JsonType("Fizetes", r.Next(200000, 5000000)));

            var jsonString = JsonConvert.SerializeObject(lista);

            File.WriteAllText("proba.json", jsonString);

            Console.WriteLine("Feltöltve!");
        }
        static void Main(string[] args)
        {
            SzovegesGeneralas();
            Console.WriteLine("Beolvasas: ");
            Beolvas();
            Console.WriteLine("Mentes: ");
            Ment();
            JsonMent();
            Console.WriteLine("Update: ");
            Update();
            //JSON


            Console.ReadKey();
        }
    }
}
