using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "This is an extension method example.";

            int totalWords = str.CountWords();

            System.Console.WriteLine("Total words in str is {0}",totalWords);
            System.Console.ReadKey();
        }
    }
}
