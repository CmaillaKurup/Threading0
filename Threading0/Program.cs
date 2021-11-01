using System;
using System.Threading;

namespace Threading0
{
    class Program
    {
        public void WorkThreadFunction()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Simple Thread");
            }
        }
    }

    class TheProg
    {
        public static void Main()
        {
            Program pg = new Program();
            Thread thread = new Thread(pg.WorkThreadFunction);
            thread.Start();
            Console.Read();
        }
    }
}