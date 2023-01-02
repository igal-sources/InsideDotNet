using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace InsideDotNet.InsideDemos
{
    internal class AsynchronousTaskDemo
    {
        public async Task<bool> CheckConnection()
        {
            return await TestConnection();
        }

        private async Task<bool> TestConnection()
        {
            var result = await Task.Run(() =>
            {
                return true;
            });

            return result;
        }
        public void RunMultipleTasks() 
        {
            Console.WriteLine("Run Multiple Tasks" + Environment.NewLine);

            Action<object> action = (object obj) =>
            {
                Console.WriteLine("Task={0}, obj={1}, Thread={2}",
                Task.CurrentId, obj,
                Thread.CurrentThread.ManagedThreadId);
            };

            // Create a task but do not start it.
            Task t1 = new Task(action, "alpha");

            // Construct a started task
            Task t2 = Task.Factory.StartNew(action, "beta");
            // Block the main thread to demonstrate that t2 is executing
            t2.Wait();

            // Launch t1 
            t1.Start();
            Console.WriteLine("t1 has been launched. (Main Thread={0})",
                              Thread.CurrentThread.ManagedThreadId);
            // Wait for the task to finish.
            t1.Wait();

            // Construct a started task using Task.Run.
            string taskData = "delta";
            Task t3 = Task.Run(() => {
                Console.WriteLine("Task={0}, obj={1}, Thread={2}",
                                   Task.CurrentId, taskData,
                                   Thread.CurrentThread.ManagedThreadId);
            });
            // Wait for the task to finish.
            t3.Wait();

            // Construct an unstarted task
            Task t4 = new Task(action, "gamma");
            // Run it synchronously
            t4.RunSynchronously();
            // Although the task was run synchronously, it is a good practice
            // to wait for it in the event exceptions were thrown by the task.
            t4.Wait();
        }

        public void RunTaskWithReturnValue()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Run Task With Return Value");

            var t1 = Task.Run(() => {
                // Just loop.
                int max = 1000000;
                int ctr = 0;
                for (ctr = 0; ctr <= max; ctr++)
                {
                    if (ctr == max / 2 && DateTime.Now.Hour <= 12)
                    {
                        ctr++;
                        break;
                    }
                }
                return ctr;
            });

            var t2 = Task<int>.Factory.StartNew(() => {
                // Just loop.
                int max = 2000000;
                int ctr = 0;
                for (ctr = 0; ctr <= max; ctr++)
                {
                    if (ctr == max / 2 && DateTime.Now.Hour <= 12)
                    {
                        ctr++;
                        break;
                    }
                }
                return ctr;
            });

            Task.WaitAll(t1, t2);
            Console.WriteLine("Finished 1 {0:N0} iterations.", t1.Result);
            Console.WriteLine("Finished 2 {0:N0} iterations.", t2.Result);
        }

        public async Task<int> GetUrlContentLengthAsync()
        {
            Console.WriteLine("Get Url Content Length Async");
            var client = new HttpClient();

            Task<string> getStringTask =
                client.GetStringAsync("https://docs.microsoft.com/dotnet");

            DoIndependentWork();

            string contents = await getStringTask;

            return contents.Length;
        }

        private void DoIndependentWork()
        {
            Console.WriteLine("Working...");
        }

        private async Task FirstAsync()
        {
            Console.WriteLine("First Async Method on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(1000);
            Console.WriteLine("First Async Method Continuation on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
        }

        private async Task SecondAsync()
        {
            Console.WriteLine("Second Async Method on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(1000);
            Console.WriteLine("Second Async Method Continuation on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
        }

        private async Task ThirdAsync()
        {
            Console.WriteLine("Third Async Method on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(1000);
            Console.WriteLine("Third Async Method Continuation on Thread with Id: " + Thread.CurrentThread.ManagedThreadId);
        }

        public async Task ExecuteAsyncFunctions()
        {
            Console.WriteLine("Execute Async Functions");
            var firstAsync = FirstAsync();
            var secondAsync = SecondAsync();
            var thirdAsync = ThirdAsync();

            await Task.WhenAll(firstAsync, secondAsync, thirdAsync);
        }
    }
}
