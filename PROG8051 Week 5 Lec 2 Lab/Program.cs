using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            // Board

            string[,] Board = { { "-", "-", "-" }, { "-", "-", "-" }, { "-", "-", "-" } };


            // Display the board
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                Console.WriteLine("");
                for(int j = 0; j < Board.GetLength(1); j++)
                {
                    Console.Write(Board[i, j] + "  ");
                }
            }
            int turn = 0;
            // User inputs
            for (int n = 0; n < 8; n++)
            {

           
            
                       
            if (turn % 2 == 0)
            {
                Console.WriteLine("\nPlayer 1's turn: ");
            }
            else
            {
                Console.WriteLine("\nPlayer 2's turn: ");
            }

            Console.WriteLine("Enter your Position: ");
            string userposition = Console.ReadLine();
            int r = 0;
            int c = 0;

            switch (userposition)
            {
                case "1":
                    r = 0;
                    c = 0;
                    break;
                case "2":
                    r = 0;
                    c = 1;
                    break;
                case "3":
                    r = 0;
                    c = 2;
                    break;
                case "4":
                    r = 1;
                    c = 0;
                    break;
                case "5":
                    r = 1;
                    c = 1;
                    break;
                case "6":
                    r = 1;
                    c = 2;
                    break;
                case "7":
                    r = 2;
                    c = 0;
                    break;
                case "8":
                    r = 2;
                    c = 1;
                    break;
                case "9":
                    r = 2;
                    c = 2;
                    break;
            }

            if(Board[r, c] != "-")
                {
                    continue;
                }

            if (turn % 2 == 0)
            {
                Board[r, c] = "X";
            }
            else
            {
                Board[r, c] = "O";
            }
                turn++; 
                    

            // Display the board
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Console.Write(Board[i, j] + "  ");
                }
            }


                // check for winner
                if (Board[0, 0] == Board[0, 1] && Board[0, 1] == Board[0, 2])
                {
                    Console.WriteLine(Board[0, 0] + " won");
                    break;
                }
                else if(Board[0, 0] == Board[1, 1] && Board[1, 1] == Board[2, 2])
                {
                    Console.WriteLine(Board[0, 0] + " won");
                    break;
                }

            }
        }
    }
}