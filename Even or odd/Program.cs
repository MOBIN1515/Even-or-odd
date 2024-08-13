using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Even_or_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter number1 :");
            string a = Console.ReadLine();
            int number = int.Parse(a);
            

            if (number % 2 == 0)
            {
                Console.WriteLine(" your number is even.");
            }
            else
            {
                Console.WriteLine("number is odd.");
            }
        }
    }
} 
