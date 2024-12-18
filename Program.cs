using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the words you want to compare");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            string Input1 = input1.ToLower();
            string Input2 = input2.ToLower();

            Console.WriteLine(IsItAnAnagram(Input1, Input2));
        }

        public static bool IsItAnAnagram (string input1, string input2)
        {
            char[]Input1 = input1.ToCharArray();
            char[]Input2 = input2.ToCharArray();

            Array.Sort(Input1);
            Array.Sort(Input2);

            return new string(Input1) == new string(Input2);
        }

        public static HashSet<char> StringToHashSet (string input)
        {
            HashSet<char> chars = new HashSet<char> ();

            foreach (char c in input)
            {
                chars.Add (c);
            }
            return chars;
        }

    }
}
