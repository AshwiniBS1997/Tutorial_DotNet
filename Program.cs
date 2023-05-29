using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsynPrg
{
    class Program
    {
        public static void Main(string[] args)
        {
            Demo();
        }

        public static void Demo()
        {
            var task1 = TaskA();
            var task2 = TaskB();
            Task.WaitAll(task1, task2);
        }

        public async static Task TaskA()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Task1");
            });
        }

        public async static Task TaskB()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("Task2");
            });
        }

    }
}
