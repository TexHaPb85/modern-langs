using System;
using System.Threading;

namespace lab6_threads
{
    class Task21
    {

        static int spoon = 1;
        static int x = 1;
        static object locker = new object();


        public static void Demo()
        {
            for (int i = 1; i < 6; i++)
            {
                Thread myThread = new Thread(Count);
                myThread.Name = "Фiлософ: " + i.ToString();
                myThread.Start();
            }

            Console.ReadLine();
        }

        public static void Count()
        {
            lock (locker)
            {
                string z = think();
                Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, z);
                Thread.Sleep(3000);
            }


            lock (locker)
            {
                string c = eat();
                Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, c);
                Thread.Sleep(2000);
            }

        }
        public static string think()
        {
           
            Random rnd = new Random();           
            int n = rnd.Next(10, 20);
            int u, u1 = 0, u2 = 1;
            string c = "";
            for (int i = 1; i < n; i++)
            {
                u = u1 + u2;
                u1 = u2;
                u2 = u;
                 c += " " + u;
                
            }
            string z = c;
            return z;
        }

        public static string eat()
        {
            bool prost = true;
            string s = "";
            for (int i = 2; i <= spoon / 2; i++)
            {
                if (spoon % i == 0)
                {
                    prost = false;
                    break;
                }
            }
            if (prost)
            {
                s = "true" + spoon;
               // Console.WriteLine("Число простое");
            }
            else
            {
                s = "false" + spoon;
                /*Console.WriteLine("Число не простое");*/
            }
            spoon++;
            return s;

        }
    }
}
