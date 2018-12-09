using Kurtis.Jobs;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurtis.Helper
{
    public class JobHelper
    {
        public async Task Init()
        {
            StdSchedulerFactory factory = new StdSchedulerFactory();
            IScheduler scheduler = await factory.GetScheduler();

            await scheduler.Start();

            #region Lock Scheduler

            IJobDetail jobLockScheduler = JobBuilder.Create<WindowsLockJob>()
            .WithIdentity("WindowsLockJob")
            .Build();

            ITrigger triggerLockScheduler = TriggerBuilder.Create()
                .WithIdentity("WindowsLockTrigger")
                .WithCronSchedule("0 0/5 * * * ?", (x) => x.Build())
                .Build();

            await ((IScheduler)scheduler).ScheduleJob(jobLockScheduler, triggerLockScheduler);

            #endregion

            #region Mouse Idle Time Scheduler

            IJobDetail jobMouseIdleScheduler = JobBuilder.Create<InputIdleLockJob>()
            .WithIdentity("MouseIdleTimeJob")
            .Build();

            ITrigger triggerMouseIdleScheduler = TriggerBuilder.Create()
                .WithIdentity("MouseIdleTimeTrigger")
                .WithCronSchedule("0 0/1 * * * ?", (x) => x.Build())
                .Build();

            await ((IScheduler)scheduler).ScheduleJob(jobMouseIdleScheduler, triggerMouseIdleScheduler);

            #endregion
        }
    }
}
