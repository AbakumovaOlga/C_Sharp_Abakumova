using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS3
{
    interface IPlay
    {
        int[,] step(int x, int y);
        void hasFree();
        void isWin();
    }
}
