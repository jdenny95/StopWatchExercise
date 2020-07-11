using System;

namespace StopWatch
{
    public class Stopwatch
    {
        private DateTime _start;
        public TimeSpan Duration { get; private set; }
        public bool RunningStatus { get; private set; }

        public void Start()
        {
            if (RunningStatus)
                throw new InvalidOperationException("You have already started the stopwatch.");

            _start = DateTime.UtcNow;
            RunningStatus = true;
        }

        public void Stop()
        {
            if(!RunningStatus)
                throw new InvalidOperationException("You have not started the stopwatch yet.");

            RunningStatus = false;
            Duration = DateTime.UtcNow - _start;
        }

        public void Exit()
        {
            Environment.Exit(0);            
        }
    }
}
