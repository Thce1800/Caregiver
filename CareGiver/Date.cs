using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareGiver
{
    class Date
    {
        public DateTime date_id { get; set; }
        public string weekday { get; set; }
        public int person_id { get; set; }
        public override string ToString()
        {
           string date = $"{date_id.ToString("dd/MM/yyyy")}";
            return $"{weekday} {date}";
        }
    }
}
