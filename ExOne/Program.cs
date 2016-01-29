using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int numberEntered = Convert.ToInt32(Console.ReadLine());
            string message = (numberEntered > 0 && numberEntered <= 10) ? ("Valid number") : ("Invalid number");
            Console.WriteLine(message);
        }
    }
}
