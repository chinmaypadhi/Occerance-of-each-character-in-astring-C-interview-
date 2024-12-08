using System;
using System.Collections.Generic;

namespace Occerance_of_each_character
{
    class Program
    {

         static void Getoccerance(string str)
        {
            string str1 = str.ToUpper();
            Dictionary<char, int> dist = new Dictionary<char, int>();

            foreach (char c in str1)
            {
                dist.TryGetValue(c, out int value);
                dist[c] = value + 1;
            }
            //string sss = "";
            foreach (var x in dist)
            {
                Console.WriteLine("Character: "+x.Key+" "+"Value: " + x.Value);
               // sss += x.Key;
            }
            //Console.WriteLine(sss);
        }
        static void Main(string[] args)
        {
            Getoccerance("chhinmmayyy");
            Console.Read();
        }
    }
}
