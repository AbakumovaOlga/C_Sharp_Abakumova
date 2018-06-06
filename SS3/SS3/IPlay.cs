using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS3
{
   public interface IPlay
    {
        int[,] step(int x, int y, int [,] m);
        bool hasFree(int [,] m);
        bool isWin(int [,] m);
        List<PlayDB> getList();
    }
}
