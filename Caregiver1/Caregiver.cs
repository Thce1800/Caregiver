﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caregiver1
{
    class Caregiver
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public override string ToString()
        {
            return $"{Id} {Firstname} {Lastname} ";
        }
    }
}
