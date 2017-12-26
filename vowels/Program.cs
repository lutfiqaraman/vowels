using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'A', 'a', 'E', 'e', 'i', 'I', 'o', 'O', 'u', 'U'};
            string str = "How was your day, Edward?";

            foreach(var vowelcharacter in vowels)
            {
                str = str.Replace(vowelcharacter, '_');
            }

            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
