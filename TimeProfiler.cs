using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication_Dictionary
{
    public class TimeProfiler
    {
        private TimeSpan elapsedTime;

        public TimeProfiler(IteratorMethod method)
        {
            if (method == IteratorMethod.foreachNonLazyCoding)
                profile_foreachNonLazyCoding();
            if(method == IteratorMethod.foreachLazyCoding)
                profile_foreachLazyCoding();
            if (method == IteratorMethod.forLoopCoding)
                profile_forLoopCoding();
        }

        public TimeSpan getElapsedTimeForExecution()
        {
            return this.elapsedTime;
        }

        // Method to profile performance of using old-school for loop
        private void profile_forLoopCoding()
        {
            Dictionary<int, string> profilingDictionary;
            MyDictionary dictionaryClass = new MyDictionary();
            profilingDictionary = dictionaryClass.getDictionary();

            //Initiate stopwatch
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < profilingDictionary.Count; i++ )
            {
                int key = i;
                string value = profilingDictionary[i];
                // Do something here
            }

            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            this.elapsedTime = stopWatch.Elapsed;

        }

        // Method to profile performance of using foreach lazy coding
        private void profile_foreachLazyCoding()
        {
            Dictionary<int, string> profilingDictionary;
            MyDictionary dictionaryClass = new MyDictionary();
            profilingDictionary = dictionaryClass.getDictionary();

            //Initiate stopwatch
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            // Lazy foreach looping
            foreach (var entry in profilingDictionary)
            {
                int key = entry.Key;
                string value = entry.Value;
                // Do something here
            }

            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            this.elapsedTime = stopWatch.Elapsed;
        }

        // Method to profile performance of foreach non-lazy coding
        private void profile_foreachNonLazyCoding()
        {
            Dictionary<int, string> profilingDictionary;
            MyDictionary dictionaryClass = new MyDictionary();
            profilingDictionary = dictionaryClass.getDictionary();

            //Initiate stopwatch
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            // Non lazy foreach looping of dictioary
            foreach (KeyValuePair<int, string> entry in profilingDictionary)
            {
                int key = entry.Key;
                string value = entry.Value;
                // Do something here
            }

            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            this.elapsedTime = stopWatch.Elapsed;
        }
    }
}

