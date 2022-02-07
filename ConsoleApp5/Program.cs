using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp5
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            var Coll = new ArrayList();
            Coll.Add("abc");
            Coll.Add(54321);
            Coll.Add(5312321);
            Coll.Add(13433122);
            Coll.Add(1213123312);
            foreach (object i in Coll)
                Console.WriteLine(i);
            Console.WriteLine();
            Coll.Remove(Coll[3]);
            foreach (object i in Coll)
                Console.WriteLine(i);
            Console.WriteLine();
            Coll.Remove(Coll[0]);
            foreach (object i in Coll)
                Console.WriteLine(i);
            Console.WriteLine();
            Coll.Sort();
            foreach (object i in Coll)
                Console.WriteLine(i);
            Console.WriteLine("--------------");


            var Coll2 = new List<int>();
            Coll2.Add(12312);
            Coll2.Add(321312312);
            Coll2.Add(321312);
            Coll2.Add(1213123);
            Coll2.Add(1213543123);
            foreach (int i in Coll2)
                Console.WriteLine(i);
            Console.WriteLine();
            Coll2.Remove(Coll2[3]);
            foreach (int i in Coll2)
                Console.WriteLine(i);
            Console.WriteLine();
            Coll2.Remove(Coll2[0]);
            foreach (int i in Coll2)
                Console.WriteLine(i);
            Console.WriteLine();
            Coll2.Sort();
            foreach (int i in Coll2)
                Console.WriteLine(i);




            Console.ReadKey();

        }
    }
}
