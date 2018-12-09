using Kurtis.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kurtis.Helper
{
    public class WindowsLockHelper
    {
        private static readonly Lazy<WindowsLockHelper> m_instance = new Lazy<WindowsLockHelper>(() => new WindowsLockHelper());

        private List<TimeModel> m_timeItems;
        private bool m_showTooltip;
        private int m_minute;
        private Action m_tooltipAction;

        private WindowsLockHelper()
        {
            SetTimes();
        }

        public static WindowsLockHelper Instance
            => m_instance.Value;

        public List<TimeModel> Times
            => m_timeItems;

        public bool LockDisable { get; set; } = false;

        public bool CheckLockTime()
        {
            if (Times.Any(x => x.Hour == DateTime.Now.Hour && x.Minute == DateTime.Now.Minute))
            {
                return true;
            }

            return false;
        }

        public void SetTooltip(bool showTooltip, int minute, Action action)
        {
            m_showTooltip = showTooltip;
            m_minute = minute;
            m_tooltipAction = action;
        }

        public void ShowTooltip()
        {
            if (!m_showTooltip)
                return;

            if (m_minute < 1)
                return;

            if (m_tooltipAction == null)
                return;

            DateTime dateTime = DateTime.Now.AddMinutes(m_minute);

            if (Times.Any(x => x.Hour == dateTime.Hour && x.Minute == dateTime.Minute))
            {
                if (m_showTooltip)
                {
                    m_tooltipAction();
                }
            }
        }

        public void SetMinute(int minute)
        {
            this.m_minute = minute;
        }

        public void SetTimes()
        {
            m_timeItems = TimeHelper.Instance.Load();
        }
    }
}