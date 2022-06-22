using System;
using System.Diagnostics;

namespace Timing
{
    public class TimerClass
    {
        TimeSpan StartingTime;
        TimeSpan Duration;

        public TimerClass() 
        {
            StartingTime = new TimeSpan(0);
            Duration = new TimeSpan(0);
        }

        public void StopTime()
        {
            Duration = Process.GetCurrentProcess()
                .Threads[0].UserProcessorTime.Subtract(StartingTime);
        }

        public void startTime()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            StartingTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
        }

        public TimeSpan Result()
        {
            return Duration;
        }
    }
}
