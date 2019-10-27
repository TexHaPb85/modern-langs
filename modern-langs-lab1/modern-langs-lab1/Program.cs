using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modern_langs_lab1
{
    class Program
    {
        static void Task1()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            if (name.Equals(""))
            {
                Console.WriteLine("Hello World, stranger greets you");
            }
            else
            {
                Console.WriteLine("Hello world, author of this app is " + name + "!");
            }
        }

        static void Task2()
        {
            DateTime today = DateTime.Now;
            DateTime birsday = new DateTime(2019, 6, 5);
            Console.WriteLine(birsday.Subtract(today).Days);
        }

        static void Main(string[] args)
        {
            Task1();
            Task2();
        }
    }
}
