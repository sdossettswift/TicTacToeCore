using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeStarter
{
    class Program
    {

        static string[] board = { " ", " ", " ",
                                  " ", " ", " ",
                                  " ", " ", " " };
        static int counter =0; 
        static void Main(string[] args)
        {
            Console.WriteLine("> Let's play a game.");
            PrintBoard();
            Play();
            Console.ReadLine();
        }

        static void Play()
        {
            Console.WriteLine("> Enter a spot. \"x,y\"");
            char[] delim = { ',' };
            string[] positions = Console.ReadLine().Split(delim); // --> "1,2" -> ["1", "2"]
            int x = Int32.Parse(positions[0]);
            int y = Int32.Parse(positions[1]);
            int index = GetIndex(x, y);            
            if ((x >= 0 && index<=3 ) && (y >= 0 && y<=3 ))
            {  
                board[index] = "X";
                counter += 1; 
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");

                Play();
                

            }
            PrintBoard(); 
            Console.WriteLine(counter); 

            Play();

        }
    
        static int GetIndex(int x, int y)
        {
            return (x - 1) + (y - 1) * 3;
        }

        static bool ValidatePlay(int index) {
            if ((index > 0) &&(index < 4))
                return true;
            else
                {
                 return  false;
                }
        }

        static bool EmptyBox (int index) {
            if (board[index] == "")
            return true; 
            else{
                return false;
            }

        }


        static void PrintBoard()
        {
            Console.WriteLine("---------");
            Console.WriteLine("| {0} | {1} | {2} |", board[0], board[1], board[2]);
            Console.WriteLine("|___|___|___|");
            Console.WriteLine("| {0} | {1} | {2} |", board[3], board[4], board[5]);
            Console.WriteLine("|___|___|___|");
            Console.WriteLine("| {0} | {1} | {2} |", board[6], board[7], board[8]);
            Console.WriteLine("---------");
        }

        static void PromptForInput()
        {

        }
    }
}
