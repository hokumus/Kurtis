using Kurtis.Helper;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurtis.Jobs
{
    public class InputIdleLockJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            if (InputIdleLockHelper.Instance.LockDisable)
                return;

            if (!InputIdleLockHelper.Instance.CheckInputIdleTime)
            {
                return;
            }

            DateTime dateTime;
            long ticks = IdleTimeFinder.GetLastInputTime(out dateTime);
            dateTime = dateTime.AddMinutes(InputIdleLockHelper.Instance.Minute);

            if (dateTime < DateTime.Now)
            {
                InteropHelper.LockWorkStation();
            }
        }
    }
}
