using Kurtis.Helper;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurtis.Jobs
{
    public class WindowsLockJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            if (WindowsLockHelper.Instance.LockDisable)
                return;

            if (WindowsLockHelper.Instance.CheckLockTime())
            {
                InteropHelper.LockWorkStation();
                return;
            }

            WindowsLockHelper.Instance.ShowTooltip();
        }
    }
}
