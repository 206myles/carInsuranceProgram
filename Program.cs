using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic car insurance approval program.

            int age;
            string dui;
            int speed;
            
            //Make sure they are at least 16.
            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());

            if (age > 15)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.ReadLine();

            //Make sure they've never had a DUI.
            Console.WriteLine("Have you ever had a DUI?");
            dui = (Console.ReadLine());
            if (dui == "no") 
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.ReadLine();

            //Make sure they have no more than 3 speeding tickets.
            Console.WriteLine("How many speeding tickets do you have?");
            speed = int.Parse(Console.ReadLine());

            if (speed < 4)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.ReadLine();

            //Check to see if candidate is qualified for insurance.
            Console.WriteLine("Qualified?");
            if ((age >15) & (dui =="no") & (speed < 4))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.ReadLine();
        }
    }
}
