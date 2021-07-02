using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Linq;

namespace LogicalProblems
{
    class StopWatch
    {
        public static void FindTimeElapse()
        {
            /*...................................
             * Stopwatch is a pre defined class 
             * .....................................*/
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();

            Thread.Sleep(900);

            stopWatch.Stop();
            /*...............................................
             * timespan is used to store the elapsed time
             * .................................................*/
            TimeSpan timeSpan = stopWatch.Elapsed;

            Console.WriteLine("Time Elapsed is :"+timeSpan+"hrs"+timeSpan+"mins"+timeSpan+"secs"+timeSpan+"ms");
        }
    }
}
