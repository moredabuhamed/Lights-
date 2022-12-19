using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lights
{
    class Program
    {

        static string[] lines = File.ReadAllLines("lights.in.txt");
        static string[] split = lines[0].Split(';');
        static char[] path = new char[int.Parse(split[1]) * int.Parse(split[0])];
        static int min = int.MaxValue;
        static int position = 0;



        static void Main(string[] args)
        {

            string[] lines = File.ReadAllLines("lights.in.txt");
            string[] split = lines[0].Split(';');
            int height = int.Parse(split[0]);
            int width = int.Parse(split[1]);
            int NumPoles = int.Parse(split[2]);
            int range = int.Parse(split[3]);

            int Xvalue = 0;
            int Yvalue = 1;
            int[] LightsArray = new int[NumPoles * 2];
            for (int i = 1; i < lines.Length; i++)
            {
                string[] split1 = lines[i].Split(';');
                LightsArray[Xvalue] = int.Parse(split1[0]);
                LightsArray[Yvalue] = int.Parse(split1[1]);
                Xvalue = Xvalue + 2;
                Yvalue = Yvalue + 2;
            }

            Park park1 = new Park(width, height, NumPoles, LightsArray, range);


            char[,] park = park1.ChangerToChar();
            for (int i = 0; i < park.GetLength(0); i++)
            {
                for (int j = 0; j < park.GetLength(1); j++)
                {
                    if (park[i, j] == 'S')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(park[i, j].ToString().PadLeft(4));

                    }
                    if (park[i, j] == 'U')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(park[i, j].ToString().PadLeft(4));
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;


            Console.Write("Coordinates of the starting point (X;Y) format ");
            string starting = Console.ReadLine();
            string[] startingspliter = starting.Split(';');
            int startingX = int.Parse(startingspliter[0]);
            int startingY = int.Parse(startingspliter[1]);


            Console.Write("Coordinates of the ending point (X;Y) format ");
            string ending = Console.ReadLine();
            string[] endingspliter = ending.Split(';');
            int endingX = int.Parse(endingspliter[0]);
            int endingY = int.Parse(endingspliter[1]);
            park[endingX - 1, endingY - 1] = 'E';


            FindMINPath(startingX - 1, startingY - 1, 'x', park);


            FindPath(startingX - 1, startingY - 1, 'x', park);

            Console.ReadLine();
        }
        static void FindMINPath(int row, int col, char direction, char[,] park)
        {

            if ((col < 0) || (row < 0) || (col >= park.GetLength(1)) || (row >= park.GetLength(0)))
            {
                return;
            }


            path[position] = direction;
            position++;

            if (park[row, col] == 'E')
            {
                minpath(path, 1, position - 1);
            }
            if (park[row, col] == 'S')
            {

                park[row, col] = 'V';

                FindMINPath(row, col - 1, 'L', park);
                FindMINPath(row - 1, col, 'U', park);
                FindMINPath(row, col + 1, 'R', park);
                FindMINPath(row + 1, col, 'D', park);

                park[row, col] = 'S';
            }

            position--;
        }
        static void FindPath(int row, int col, char direction, char[,] park)
        {

            if ((col < 0) || (row < 0) || (col >= park.GetLength(1)) || (row >= park.GetLength(0)))
            {
                return;
            }


            path[position] = direction;
            position++;

            if (park[row, col] == 'E' && position - 2 == min)
            {
                Console.Write("Shortest path : ");
                for (int pos = 1; pos <= position - 1; pos++)
                {
                    Console.Write(path[pos] + " ");
                }
                return;
            }
            if (park[row, col] == 'S')
            {

                park[row, col] = 'V';
                FindPath(row, col - 1, 'L', park);
                FindPath(row - 1, col, 'U', park);
                FindPath(row, col + 1, 'R', park);
                FindPath(row + 1, col, 'D', park);
                park[row, col] = 'S';
            }

            position--;
        }
        static void minpath(char[] path, int startPos, int endPos)
        {
            if (endPos - startPos < min)
            {
                min = endPos - startPos;
            }

        }

    }
}
