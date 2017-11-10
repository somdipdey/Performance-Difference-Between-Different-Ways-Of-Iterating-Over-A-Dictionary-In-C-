using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Profiling initiated....");

            // Run the method iterating dictionary using for loop
            TimeProfiler timeProfilerForLoopCoding = new TimeProfiler(IteratorMethod.forLoopCoding);
            var elapsedTime1 = timeProfilerForLoopCoding.getElapsedTimeForExecution();
            Console.WriteLine("TimeSpan for IteratorMethod.forLoopCoding: " + elapsedTime1);

            // Run the method iterating dictionary using foreach lazy coding
            TimeProfiler timeProfilerForeachLazyCoding = new TimeProfiler(IteratorMethod.foreachLazyCoding);
            var elapsedTime2 = timeProfilerForeachLazyCoding.getElapsedTimeForExecution();
            Console.WriteLine("TimeSpan for IteratorMethod.foreachLazyCoding: " + elapsedTime2);

            // Run the method iterating dictionary using foreach non-lazy coding
            TimeProfiler timeProfilerForeachNonLazyCoding = new TimeProfiler(IteratorMethod.foreachNonLazyCoding);
            var elapsedTime3 = timeProfilerForeachNonLazyCoding.getElapsedTimeForExecution();
            Console.WriteLine("TimeSpan for IteratorMethod.foreachNonLazyCoding: " + elapsedTime3);

            Console.ReadLine();
        }
    }
}
