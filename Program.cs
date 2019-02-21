using System;
using System.Threading;
namespace ThreadMethod
{
    class Program
    {
        public static int number = 0;
        static Thread print = new Thread(new ThreadStart(Print));
        static Thread generatenumber = new Thread(new ThreadStart(GenerateNumber));
        static Mutex mutex = new Mutex();
        static void Main(string[] args)
        {
            Console.WriteLine("Start to write number");
            generatenumber.Start();
            print.Start();
            Console.ReadKey();

        }
        public static void Print()
        {
            for (;;)
            {
                if (number == 100)
                {
                    break;
                }
                else
                {
                    mutex.WaitOne();
                    Random r = new Random();
                    int s = r.Next(1, 3001);
                    Console.WriteLine(number);
                    Thread.Sleep(s);
                    mutex.ReleaseMutex();
                }
            }
           
        }

        static void GenerateNumber()
        {
            for (;;)
            {

                if (number == 100)
                {
                    break;
                }
                else
                {
                    mutex.WaitOne();
                    Random rand = new Random();
                    int k = rand.Next(1, 3001);
                    number++;
                    Thread.Sleep(k);
                    mutex.ReleaseMutex();
                }
            }
        }
    }
}
