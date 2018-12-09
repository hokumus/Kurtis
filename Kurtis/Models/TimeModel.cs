using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurtis.Models
{
    public class TimeModel
    {
        public TimeModel()
        {

        }

        public TimeModel(string hour, string minute )
        {
            this.ID = Guid.NewGuid();
            this.Hour = Convert.ToInt32(hour);
            this.Minute = Convert.ToInt32(minute);
        }

        public Guid ID { get; set; }

        public int Hour { get; set; }

        public int Minute { get; set; }

        public string DisplayText => $"{Hour.ToString().PadLeft(2, '0')}:{Minute.ToString().PadLeft(2, '0')}";
    }
}
