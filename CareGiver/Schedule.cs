using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareGiver
{
    class Schedule
    {
        public int schedule_id { get; set; }
        public DateTime date_id { get; set; }
        public string weekday { get; set; }
        public bool breakfast { get; set; }
        bool snack { get; set; }
        public int person_id { get; set; }
        public int nonattendane_id { get; set; }
        public DateTime time_start { get; set; }
        public DateTime time_end { get; set; }
        public bool attendance { get; set; }

        public override string ToString()
        {
            //FÅ DATUMET ATT VISAS UTAN TID
            return date_id.ToString("dd/MM/yyyy") + " " + weekday + " " + breakfast + " " + attendance;
        }
    }
}
