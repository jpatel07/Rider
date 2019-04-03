using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public static class TimeSpanExtensions
    {
        public static TimeSpan RoundTo(this TimeSpan timeSpan, int n)
        {
            return TimeSpan.FromMinutes(n * Math.Ceiling(timeSpan.TotalMinutes / n));
        }

    }
}
