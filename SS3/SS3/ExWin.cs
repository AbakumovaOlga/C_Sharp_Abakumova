﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS3
{
    class ExWin : Exception
    {
        public ExWin(string winner) : base("Победа  " + winner)
        {
        }
    }
}
