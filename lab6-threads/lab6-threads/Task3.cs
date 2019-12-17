using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab6_threads
{
    class Task3
    {
        private static int N = 4;
        private static int M = 64;
        static object locker = new object();

        static double operation(double x)
        {
            double numerator = 0;
            double denomerator = 0;
            for(int i = 1; i< 6; i++)
            {
                numerator += (x - Math.Pow(2, i));
            }
            for (int i = 1; i <= 63; i+=2)
            {
                denomerator += (x - i);
            }
            return numerator / denomerator;
        }

        public static void Count()
        {
            lock (locker)
            {
                double res = 0;
                for (int i = 0; i < M; i++)
                    res += operation(res);
                Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, res);
            }

        }
        public static void Demo()
        {
            for (int i = 1; i < N; i++)
            {
                Thread myThread = new Thread(Count);
                myThread.Name = "Потiк " + i.ToString();
                myThread.Start();
            }

            Console.ReadLine();
        }

    }
}
