using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeStarter
{
    class Program
    {
        /*empty board and empty counters*/
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
            List<int> oPlays = new List<int>();
            List<int> xPlays = new List<int>();
            
            int x = Int32.Parse(positions[0]);
            int y = Int32.Parse(positions[1]);
            int index = GetIndex(x, y);

            if (EmptySpot(index))
            {
               if ((x > 0 && x < 4 ) && (y > 0 && y < 4 ))
                    {  
                        if (counter % 2 == 0){
                            board[index] = "X";
                            xPlays.Add(index);
                            counter += 1; 
                            
                        }
                        else{
                            board[index] = "O";
                            oPlays.Add(index);
                            counter += 1; 
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again.");

                        Play();
                        

                    }
                    PrintBoard(); 
                    Console.WriteLine(counter); 
                    if (Winner() || Draw()){

                    }
                    else{
                        Play(); 
                    }

                    Play();

                }
                else {
                    Play(); 
                }

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



        static bool EmptySpot (int i) {
            if (board[i] != "X" && board[i]!="O"){
                return true;                
            }
            
            else{
                Console.WriteLine("Seat's taken. Try again.");
                return false;
            }

        }

        static bool Winner()
        {
            if (
                (board[0] == board[1] && board[1] == board[2] && board[1] != " ") ||
                (board[3] == board[4] && board[4] == board[5] && board[4] != " ") ||
                (board[6] == board[7] && board[7] == board[8] && board[7] != " ") ||
                (board[0] == board[4] && board[4] == board[8] && board[4] != " ") ||
                (board[2] == board[4] && board[4] == board[6] && board[4] != " ") ||
                (board[0] == board[3] && board[3] == board[6] && board[3] != " ") ||
                (board[1] == board[4] && board[4] == board[7] && board[4] != " ") ||
                (board[2] == board[5] && board[5] == board[8] && board[5] != " ")
                )
            {
                Console.WriteLine("We've got a winner!");
                return true; 
                }
            else 
            {
                return false; 
            }
        }

         static bool Draw()
        {
            if ((board[0] != " " && Winner()==false) &&
                (board[1] != " " && Winner() == false) &&
                (board[2] != " " && Winner() == false) &&
                (board[3] != " " && Winner() == false) &&
                (board[4] != " " && Winner() == false) &&
                (board[5] != " " && Winner() == false) &&
                (board[6] != " " && Winner() == false) &&
                (board[7] != " " && Winner() == false) &&
                (board[8] != " " && Winner() == false))
            {
                Console.WriteLine("Draw!");
                return true;
            } else
            {
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
