using Kurtis.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Kurtis.Helper
{
    public class TimeHelper
    {
        private static readonly Lazy<TimeHelper> m_instance = 
            new Lazy<TimeHelper>(() => new TimeHelper());

        private const string TIME_FILE_NAME = "Time.xml";
        private const string TIME_REGEX_PATTERN = "^([0-9]|0[0-9]|1[0-9]|2[0-4]):([0-9]|[0-4][0-9]|5[0-9])$";

        public static TimeHelper Instance
            => m_instance.Value;

        private string FilePath
            => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, TIME_FILE_NAME);

        public List<TimeModel> Load()
        {
            if (!File.Exists(FilePath))
                return null;

            using (var stream = System.IO.File.OpenRead(FilePath))
            {
                var serializer = new XmlSerializer(typeof(List<TimeModel>));
                return serializer.Deserialize(stream) as List<TimeModel>;
            }
        }

        public void Save(List<TimeModel> items)
        {
            if (items == null)
                return;

            using (var writer = new System.IO.StreamWriter(FilePath))
            {
                var serializer = new XmlSerializer(typeof(List<TimeModel>));
                serializer.Serialize(writer, items);
                writer.Flush();
            }
        }
    }
}
