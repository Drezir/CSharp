using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var taskCompletionSource = new TaskCompletionSource<bool>();

            new Thread(() =>
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                taskCompletionSource.TrySetResult(true);
            }).Start();

            var test = taskCompletionSource.Task.Result;
            */

            Enumerable.Range(0, 100).ToList().ForEach(f =>
            {
                ThreadPool.QueueUserWorkItem((o) =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Thread id: {0}", Thread.CurrentThread.ManagedThreadId);
                });
            });

            Console.ReadLine();
        }
    }
}
