using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS3
{
    class Play : IPlay
    {
        PlayContext context;
        static int N;
        static int[,] matrix;// -1 пустая
        bool cross;
        public Play(int n, PlayContext context, bool cr = true)
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

        public List<PlayDB> getList()
        {
            List<PlayDB> res = new List<PlayDB>();
            foreach (PlayDB p in context.Plays)
            {
                res.Add(p);
            }
            return res;
        }

        public void hasFree()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] == -1)
                    {
                        return;
                    }
                }
            }
            PlayDB winner = new PlayDB { Winner = "Ничья." };
            context.Plays.Add(winner);
            context.SaveChanges();
            throw new Exception("Ничья.");
        }

        public void isWin()
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
                    if (matrix[i, j] == 1)
                    {
                        XLine++;
                    }
                    if (matrix[i, j] == 0)
                    {
                        OLine++;
                    }
                    if (matrix[j, i] == 1)
                    {
                        XCol++;
                    }
                    if (matrix[j, i] == 0)
                    {
                        OCol++;
                    }
                }
                if (matrix[i, i] == 1)
                {
                    XMainDia++;
                }
                if (matrix[i, i] == 0)
                {
                    OMainDia++;
                }
                if (matrix[i, N - 1 - i] == 1)
                {
                    XSecDia++;
                }
                if (matrix[i, N - 1 - i] == 0)
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
        }

        public int[,] step(int y, int x)
        {
            if (x >= N || y >= N)
            {
                throw new Exception("Выход за границы поля");
            }
            hasFree();

            if (matrix[x, y] == -1)
            {
                if (cross)
                {
                    matrix[x, y] = 1;
                    cross = false;
                }
                else
                {
                    matrix[x, y] = 0;
                    cross = true;
                }
                isWin();
                return matrix;
            }
            else
            {
                throw new Exception("Эта клетка занята");
            }
        }
    }
}
