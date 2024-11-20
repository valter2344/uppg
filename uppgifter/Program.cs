using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberAsString = "887";
            int number = int.Parse(numberAsString);
            Console.WriteLine("The value might be " + number);
            Console.ReadLine();
        }
    }
}
