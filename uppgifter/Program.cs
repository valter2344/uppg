using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppg5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your grade ");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade == 0)
            {
                Console.WriteLine("Fail");
            }
            else if (grade == 1)
            {
                Console.WriteLine("Needs improvement");
            }
            switch (grade)
            {
                case 0:
                    Console.WriteLine("Fail");
                    break;


                case 1:
                    Console.WriteLine("Needs improvement");
                    break;
                case 2:
                    Console.WriteLine("ok");
                    break;
                case 3:
                    Console.WriteLine("Satisfactory");
                    break;
                case 4:
                    Console.WriteLine("Good");
                    break;
                case 5:
                    Console.WriteLine("Excellent");
                    break;
                
                    
                default:
                    Console.WriteLine("Invalid, enter a value between 0 and 5");
                    break;
            }
            Console.ReadLine();
        }
    }
}
