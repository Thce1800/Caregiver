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
        public DateTime date_idn { get; set; }
        public string weekday { get; set; }
        public bool breakfast { get; set; }
        bool snack { get; set; }
        public int person_id { get; set; }
        public int nonattendane_id { get; set; }
        public DateTime time_startn { get; set; }
        public DateTime time_endn { get; set; }
        public string time_start { get; set; }
        public string time_end { get; set; }
        public bool attendance { get; set; }
        public string string_date { get; set; }

        public override string ToString()
        {
            //FÅ DATUMET ATT VISAS UTAN TID
            return date_idn.ToString("dd/MM/yyyy") + " " + weekday + " " + breakfast + " " + attendance;
            // + " " + time_start.ToString("HH:mm") + " " + time_end.ToString("HH:mm");
        }
    }
    //    public int schedule_id { get; set; }
    //    public string date_id { get; set; }
    //    public string weekday { get; set; }
    //    public bool breakfast { get; set; }
    //    bool snack { get; set; }
    //    public int person_id { get; set; }
    //    public int nonattendane_id { get; set; }
    //    public string time_start { get; set; }
    //    public string time_end { get; set; }
    //    public bool attendance { get; set; }

    //    public override string ToString()
    //    {
    //        //FÅ DATUMET ATT VISAS UTAN TID
    //        return date_id + " " + weekday + " " + breakfast +  " "+ attendance+ " "+ time_start+ " " + time_end;

    //    }
}

