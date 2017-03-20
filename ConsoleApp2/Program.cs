using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////串行
            //var time = new Stopwatch();
            //time.Start();
            //Run1();
            //Run2();
            //Console.WriteLine("总共用时： " + time.Elapsed);
            //Console.ReadKey();

            //// Parallel 并行
            //var time = new Stopwatch();
            //time.Start();
            //Parallel.Invoke(Run1, Run2);
            //Console.WriteLine("总共用时： " + time.Elapsed);
            //Console.ReadKey();


            ////并行For
            //var time = new Stopwatch();
            //time.Start();
            //Parallel.For(0, 100,new ParallelOptions { MaxDegreeOfParallelism=2}, i => Run3(i));
            //Console.WriteLine("总共用时： " +time.Elapsed);
            //Console.ReadKey();

            ////串行for
            //var time = new Stopwatch();
            //time.Start();
            //for (int i = 0; i < 100; i++)
            //{
            //    Run3(i);
            //}
            //Console.WriteLine(time.Elapsed);
            //Console.ReadKey();






        }
        static void Run1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("我是Run1，我运行了3s");
        }
        static void Run2()
        {
            Thread.Sleep(5000);
            Console.WriteLine("我是Run2，我运行了5s");
        }
        
        static void Run3(int i)
        {
            Thread.Sleep(300);
            Console.WriteLine(i);
        }


    }
}
