using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurtis.Helper
{
    public class InputIdleLockHelper
    {
        private static readonly Lazy<InputIdleLockHelper> m_instance =
            new Lazy<InputIdleLockHelper>(() => new InputIdleLockHelper());

        public static InputIdleLockHelper Instance
            => m_instance.Value;

        public bool CheckInputIdleTime { get; set; } = false;

        public int Minute { get; set; }

        public bool LockDisable { get; set; } = false;
    }
}
