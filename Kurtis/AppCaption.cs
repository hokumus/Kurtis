using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Kurtis
{
    class AppCaption
    {
        private static Lazy<AppCaption> m_instance 
            = new Lazy<AppCaption>(() => new AppCaption());

        public static AppCaption Instance 
            => m_instance.Value;

        public string Caption
        {
            get
            {
                AssemblyTitleAttribute title = (AssemblyTitleAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false).First();
                string appName = title.Title;
                Version version = Assembly.GetExecutingAssembly().GetName().Version;

                return string.Format("{0} v{1}.{2}", appName, version.Major, version.Minor);
            }
        }
    }
}
