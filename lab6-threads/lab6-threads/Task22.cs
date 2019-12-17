using System;
using System.Threading;

namespace lab6_threads
{
    class Task22
    {

        static double spoon = 0;
        static int x = 1;
        static object locker = new object();

        public static void Demo()
        {
            for (int i = 1; i < 6; i++)
            {
                Thread myThread = new Thread(Count);
                myThread.Name = "Потiк " + i.ToString();
                myThread.Start();
            }

            Console.ReadLine();
        }

        public static void Count()
        {
            lock (locker)
            {
                double z = eat();
                Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, z);
            }

        }

        public static double eat()
        {
            double z = 0;
            int factorial=1;
            for (int i = 1; i < 67; i++)
            {

                z +=  Math.Pow(x, i + 2) / (factorial * (i+2));

            }
            spoon += z;
            return spoon;
        }
    }
}
