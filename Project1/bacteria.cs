﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Bacteria
    {
        private Nucleus nucleus;
        private int flagellaCount;
        public Bacteria()
        {
            nucleus = new Nucleus(0, 0);
            flagellaCount = 15;
        }
    }
}
