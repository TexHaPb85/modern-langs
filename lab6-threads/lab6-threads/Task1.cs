using System;
using System.Threading;

namespace lab6_threads
{
    class Task1
    {
        static int x = 0;
        static object locker = new object();

        public static void unsafedCount()
        {
            x += 1;
            Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, x);
        }

        public static void unsafed()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread myThread = new Thread(unsafedCount);
                myThread.Name = "Потік що виконуэться: " + myThread.ToString() + i;
                myThread.Start();
            }

            Console.ReadLine();
        }

        public static void blockedCount()
        {
            lock (locker)
            {
                x += 1;
                Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, x);
            }
        }

        public static void blockedElement()
        {
            for (int i = 1; i < 6; i++)
            {
                Thread myThread = new Thread(blockedCount);
                myThread.Name = "Потік що виконуэться: " + myThread.ToString() + i;
                myThread.Start();
            }

            Console.ReadLine();
        }

        public static void priorityExamples()
        {
            for (int i = 1; i < 6; i++)
            {
                Thread myThread = new Thread(blockedCount);
                myThread.Name = "Потік що виконуэться: " + myThread.ToString() + i;
                myThread.Priority = ThreadPriority.AboveNormal;
                myThread.Start();
            }
            Console.ReadLine();
        }
    }
}
