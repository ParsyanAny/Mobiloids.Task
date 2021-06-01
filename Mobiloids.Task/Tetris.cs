using System;

namespace Mobiloids.Task
{
    class Tetris
    {
        public static void MoveDown(int[,] board, int height, int width)
        {
            int count = 0;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (board[i, j] == 1)
                        count++;
                    else
                        break;
                }
                if (count == width)
                {
                    for (int x = i; x < height - 1; x++)
                    {
                        for (int y = 0; y < width; y++)
                            board[x, y] = board[x + 1, y];
                    }
                    for (int x = height-1; x < height; x++)
                    {
                        for (int y = 0; y < width; y++)
                            board[x, y] = 0;
                    }
                    count = 0;
                    i--;
                }
                else
                    count = 0;
            }
        }

        public static void Print(int[,] board, int height, int width)
        {
            for (int  i = height-1;  i >= 0;  i--)
            {
                for (int y = 0; y < width; y++)
                {
                    Console.Write($"{board[i,y]}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
