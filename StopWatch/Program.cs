using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To start the stopwatch, type 'start'. To stop the stopwatch, type 'stop'. When you want to exit the application, type 'exit'.");
            var stopwatch = new Stopwatch();

            while (true)
            {
                try
                {
                    var input = Console.ReadLine();

                    switch (input.ToLower())
                    {
                        case "start":
                            stopwatch.Start();
                            break;
                        case "stop":
                            stopwatch.Stop();
                            Console.WriteLine(stopwatch.Duration);
                            break;
                        case "exit":
                            stopwatch.Exit();
                            break;
                        default:
                            Console.WriteLine("Unexpect input. Please type 'start' to start the stopwatch, 'stop' to stop it or 'exit' to exit the application.");
                            break;
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
