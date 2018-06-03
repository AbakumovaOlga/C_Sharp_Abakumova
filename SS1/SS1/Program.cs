using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS1
{
    class Program
    {

        private static int N = 3;
        static int[,] matrix = new int[N, N];
        static void Main(string[] args)
        {
            create();
            result();
            play();
        }

        private static void play()
        {
            bool cross = true;
            int x = 0;
            int y = 0;
            while (hasFree())
            {
                string[] line = Console.ReadLine().Split();
                if (line.Length <= 2)
                {
                    x = Convert.ToInt32(line[0]);
                    y = Convert.ToInt32(line[1]);
                    if (x >= N || y >= N)
                    {
                        Error("Выход за границы поля");
                    }
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
                        result();
                        isWin();
                    }
                    else
                    {
                        Error("Эта клетка занята");
                    }
                }
                else
                {
                    Error("Введено больше двух значений");
                }
            }
            Console.WriteLine("Ничья.");
            Console.ReadLine();
        }

        private static void isWin()
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
                if (XMainDia == N || XSecDia == N|| XLine == N|| XCol == N)
                {
                    WIN("X");
                }
                if (OMainDia == N || OSecDia == N|| OLine == N|| OCol == N)
                {
                    WIN("0");
                }

            }
        }

        private static void WIN(string winner)
        {
            Console.WriteLine("Победа " + winner);
            Console.ReadLine();
            System.Environment.Exit(0);
        }

        private static void Error(string er)
        {
            Console.WriteLine("Вы нарушаете правила. " + er);
            Console.ReadLine();
            System.Environment.Exit(0);
        }

        private static void result()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] != -1)
                    {
                        Console.Write(matrix[i, j] + "   ");
                    }else
                    {
                        Console.Write(matrix[i, j] + "  ");
                    }
                }
                Console.WriteLine();
            }
        }

        private static bool hasFree()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] == -1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static void create()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = -1;
                }
            }
        }

    }
}
