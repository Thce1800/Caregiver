using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caregiver1
{
    class Child
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        //public string Lastname { get; set; } //Behövs efternamn?

        public override string ToString()
        {
            return $"{Id} {Firstname}";
        }
    }
}
