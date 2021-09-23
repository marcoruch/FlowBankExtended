using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowBank_Extended.API
{
    public static class Helpers
    {
        public static IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (DateTime day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
            {
                yield return day;
            }
        }
    }
}
