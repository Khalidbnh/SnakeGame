using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Program
    {
        static int width, height;
        static int playerX, playerY;
        static char[,] snakeBoard;
        static bool isRunning = true;


        static void Main(string[] args)
        {
            InitializeBoard();

            

            Console.ReadKey();
        }

        static void InitializeBoard()
        {
            string punto = ".";

            Console.WriteLine("Enter grid width:");
            width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter grid height:");
            height = int.Parse(Console.ReadLine());
            Debug.WriteLine("width is " + width);

            // Initialize the grid and set the player at the center
            snakeBoard = new char[height, width];

            char fillValue = '.';
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    snakeBoard[i, j] = fillValue;                 
                }
            }


            DisplayBoard(width, height, snakeBoard);

           
          


           
        }


        static void DisplayBoard(int rows, int cols, char[,] snakeBoard)
        {

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine("       |       |       ");

                for (int j = 0; j < cols; j++)
                {
                    // Print the board cell
                    Console.Write($"   {snakeBoard[i, j]}   ");

                    // Print the column separators if it's not the last column
                    if (j < cols - 1)
                        Console.Write("|");
                }

                Console.WriteLine(); // Move to the next line after printing the row

                // Print the row separators if it's not the last row
                if (i < rows - 1)
                {
                    Console.WriteLine("_______|_______|_______");
                }
            }
            Console.WriteLine("       |       |       "); // Bottom border

        }
    }
}
