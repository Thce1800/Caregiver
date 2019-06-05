using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareGiver
{
    class Caregiver
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        
        public int CurrentId { get; set; }

        public override string ToString()
        {
            return $"{Id} {Firstname} {Lastname} ";
        }
    }
}
