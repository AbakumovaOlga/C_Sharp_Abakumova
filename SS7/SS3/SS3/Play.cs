using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS3
{
   public class Play : IPlay
    {
        PlayContext context;
        static int N;
        static int[,] matrix;// -1 пустая
        bool cross;
        public Play(int n,PlayContext context, bool cr = true)
        {
            this.context = context;
            N = 3;
            cross = cr;
            matrix = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = -1;
                }
            }
        }

        public int [,] getMatrix()
        {
            return matrix;
        }

        public List<PlayDB> getList()
        {
            List<PlayDB> res = new List<PlayDB>();
            foreach (PlayDB p in context.Plays.ToList())
            {
                res.Add(p);
            }
            return res;
        }

        public bool hasFree(int [,] m)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (m[i, j] == -1)
                    {
                        return true;
                    }
                }
            }
            PlayDB winner = new PlayDB { Winner = "Ничья." };
            context.Plays.Add(winner);
            context.SaveChanges();
            throw new Exception("Ничья.");
        }

        public bool isWin(int[,] m)
        {
            int XMainDia = 0;
            int OMainDia = 0;
            int XSecDia = 0;
            int OSecDia = 0;
            for (int i = 0; i < N; i++)
            {
                int XLine = 0;
                int OLine = 0;
                int XCol = 0;
                int OCol = 0;
                for (int j = 0; j < N; j++)
                {
                    if (m[i, j] == 1)
                    {
                        XLine++;
                    }
                    if (m[i, j] == 0)
                    {
                        OLine++;
                    }
                    if (m[j, i] == 1)
                    {
                        XCol++;
                    }
                    if (m[j, i] == 0)
                    {
                        OCol++;
                    }
                }
                if (m[i, i] == 1)
                {
                    XMainDia++;
                }
                if (m[i, i] == 0)
                {
                    OMainDia++;
                }
                if (m[i, N - 1 - i] == 1)
                {
                    XSecDia++;
                }
                if (m[i, N - 1 - i] == 0)
                {
                    OSecDia++;
                }
                if (XMainDia == N || XSecDia == N || XLine == N || XCol == N)
                {
                    PlayDB winner = new PlayDB { Winner = "Победа X" };
                    context.Plays.Add(winner);
                    context.SaveChanges();
                    throw new ExWin("X");
                }
                if (OMainDia == N || OSecDia == N || OLine == N || OCol == N)
                {
                    PlayDB winner = new PlayDB { Winner = "Победа 0" };
                    context.Plays.Add(winner);
                    context.SaveChanges();
                    throw new ExWin("0");
                }
            }
            return false;
        }

        public int[,] step(int y, int x, int [,] m)
        {
            if (x >= N || y >= N)
            {
                throw new Exception("Выход за границы поля");
            }
            hasFree(m);

            if (m[x, y] == -1)
            {
                if (cross)
                {
                    m[x, y] = 1;
                    cross = false;
                }
                else
                {
                    m[x, y] = 0;
                    cross = true;
                }
                isWin(m);
                return m;
            }
            else
            {
                throw new Exception("Эта клетка занята");
            }
        }

        public string allWinner(List<PlayDB> list)
        {
            string res = "";
            int countX = 0;
            int count0 = 0;
            foreach(PlayDB p in list)
            {
                if(p.Winner.Equals("Победа X"))
                {
                    countX++;
                }
                if(p.Winner.Equals("Победа 0"))
                {
                    count0++;
                }
            }
            if(countX>count0) res= "Победа X";
            if (count0 > countX) res = "Победа 0";
            if (countX == count0) res = "Ничья";
            return "Общая " + res;
        }
    }
}
