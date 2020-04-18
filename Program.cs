using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] matrix =
        {
                {'1','2','3'},
                {'4','5','6'},
                {'7','8','9'}
        };

        private static bool running = true;
        private static int input = 0;
        private static bool inputCorrect = true;
        private static char playerSign;

        static void Main(string[] args)
        {
            Console.WriteLine("                                                 ");
            Console.WriteLine("Select a color for your text: Dark Blue, Blue, Light Blue, Red, Green. If no color is selected the color will default.");
            string inputColor = Console.ReadLine();
            string[] colors = { "1", "2", "3", "4", "5" };
            

            switch (inputColor)
            {
                case "red":
                    colors[0] = "red";
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Color is now red."); break;
                case "Red":
                    colors[0] = "red";
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Color is now red."); break;
                case "dark blue":
                    colors[1] = "dark blue";
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Color is now Dark Blue."); break;
                case "Dark Blue": 
                    colors[1] = "dark blue";
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Color is now Dark Blue."); break;
                case "blue":
                    colors[2] = "blue";
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Color is now Blue."); break;
                case "Blue":
                    colors[2] = "blue";
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Color is now Blue."); break;
                case "light blue":
                    colors[3] = "light blue";
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(" Color is now Light Blue."); break;
                case "Light Blue":
                    colors[3] = "light blue";
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(" Color is now Light Blue."); break;
                case "green":
                    colors[4] = "green";
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Color is now Green."); break;
                case "Green":
                    colors[4] = "green";
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Color is now Green."); break;
            }
            
            int player = 2;
            bool reenter;

            //Runs the code so long as the program runs. 
            do
            {
                //this will switch bewtween players. 2 is used in the 'int player = ...' because it sets the range of the number of players. 
                if (player == 2)
                {
                    player = 1;
                    Entry(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    Entry(player, input);
                }

                do
                {
                    WinO();
                    WinX();
                    
                    if (inputCorrect)
                    {
                        BoardMatrix();
                        Console.WriteLine("           Get three in a row to win. Play an inproper tile or a letter, you will lose your turn.");
                        Console.WriteLine("                 You cannot play a tile that is already in play, you will lose your turn.");
                        Console.WriteLine("                                 Enter '100' or greater to exit app.");
                        Console.WriteLine("                                         To Reset enter 42.");
                        Console.WriteLine("                                Ready Player {0}? Enter a tile 1-9 now.", player);
                       
                        reenter = int.TryParse(Console.ReadLine(), out input);
                        if(input == 42)
                        {
                            Reset();
                        }
                        else if (input >= 100)
                        {
                            Console.WriteLine("Exiting App...Press any key");
                            Console.ReadKey();
                            running = false;
                        }
                        else if (!reenter)
                        {
                            Console.WriteLine("Plase enter a valid tile number 1-9. You lose your turn.");
                            Console.ReadKey();
                        }
                        else if (input > 9)
                        {
                            Console.WriteLine("Plase enter a valid tile number 1-9. You lose your turn.");
                            Console.ReadKey();
                        }
                        else if (input < 1)
                        {
                            Console.WriteLine("Plase enter a valid tile number 1-9. You lose your turn.");
                            Console.ReadKey();
                        }
                    }
                }
                while (!inputCorrect);
                Console.Clear();

            }
            while (running);
        }

        public static void BoardMatrix()
        {
            Console.WriteLine("                                                                   ");
            Console.WriteLine("                                                 |     |       ");
            Console.WriteLine("                                              {0}  |  {1}  |  {2}  ", matrix[0, 0], matrix[0, 1], matrix[0, 2]);
            Console.WriteLine("                                           ______|_____|______       ");
            Console.WriteLine("                                                 |     |       ");
            Console.WriteLine("                                              {0}  |  {1}  |  {2}  ", matrix[1, 0], matrix[1, 1], matrix[1, 2]);
            Console.WriteLine("                                           ______|_____|______       ");
            Console.WriteLine("                                                 |     |       ");
            Console.WriteLine("                                              {0}  |  {1}  |  {2}  ", matrix[2, 0], matrix[2, 1], matrix[2, 2]);
            Console.WriteLine("                                                 |     |       ");
            Console.WriteLine("                                                                   ");
        }

        public static void Entry(int player, int input)
        {
            if (player == 1)
            {
                playerSign = 'O';
            }
            else if (player == 2)
            {
                playerSign = 'X';
            }

            switch (input)
            {
                case 1:
                    if (matrix[0, 0].Equals('1'))
                    {
                        matrix[0, 0] = playerSign;
                    }; break;
                case 2:
                    if (matrix[0, 1].Equals('2'))
                    {
                        matrix[0, 1] = playerSign;
                    }; break;
                case 3:
                    if (matrix[0, 2].Equals('3'))
                    {
                        matrix[0, 2] = playerSign;
                    }; break;
                case 4:
                    if (matrix[1, 0].Equals('4'))
                    {
                        matrix[1, 0] = playerSign;
                    }; break;
                case 5:
                    if (matrix[1, 1].Equals('5'))
                    {
                        matrix[1, 1] = playerSign;
                    }; break;
                case 6:
                    if (matrix[1, 2].Equals('6'))
                    {
                        matrix[1, 2] = playerSign;
                    }; break;
                case 7:
                    if (matrix[2, 0].Equals('7'))
                    {
                        matrix[2, 0] = playerSign;
                    }; break;
                case 8:
                    if (matrix[2, 1].Equals('8'))
                    {
                        matrix[2, 1] = playerSign;
                    }; break;
                case 9:
                    if (matrix[2, 2].Equals('9'))
                    {
                        matrix[2, 2] = playerSign;
                    }; break;
            };

        }

        public static void WinX()
        {
            //first horizontal win condition for X.
            if (matrix[0, 0] == 'X' && matrix[0, 1] == 'X' && matrix[0, 2] == 'X')
            {
                Console.WriteLine("                                     ");
                Console.WriteLine("Player 1 wins!");
                Console.WriteLine("                                     ");
                Console.WriteLine("Resetting. Press any key...");
                Console.ReadLine();
                Console.Clear();
                Reset();
            }
            else if (matrix[1, 0] == 'X' && matrix[1, 1] == 'X' && matrix[1, 2] == 'X')
            {
                Console.WriteLine("                                     ");
                Console.WriteLine("Player 1 wins!");
                Console.WriteLine("                                     ");
                Console.WriteLine("Resetting. Press any key...");
                Console.ReadLine();
                Console.Clear();
                Reset();
            }
            else if (matrix[2, 0] == 'X' && matrix[2, 1] == 'X' && matrix[2, 2] == 'X')
            {
                Console.WriteLine("                                     ");
                Console.WriteLine("Player 1 wins!");
                Console.WriteLine("                                     ");
                Console.WriteLine("Resetting. Press any key...");
                Console.ReadLine();
                Console.Clear();
                Reset();
            }
            //first virtical win conditions for X.
            else if (matrix[0, 0] == 'X' && matrix[1, 0] == 'X' && matrix[2, 0] == 'X')
            {
                Console.WriteLine("                                     ");
                Console.WriteLine("Player 1 wins!");
                Console.WriteLine("                                     ");
                Console.WriteLine("Resetting. Press any key...");
                Console.ReadLine();
                Console.Clear();
                Reset();
            }
            else if (matrix[0, 1] == 'X' && matrix[1, 1] == 'X' && matrix[2, 1] == 'X')
            {
                Console.WriteLine("                                     ");
                Console.WriteLine("Player 1 wins!");
                Console.WriteLine("                                     ");
                Console.WriteLine("Resetting. Press any key...");
                Console.ReadLine();
                Console.Clear();
                Reset();
            }
            else if (matrix[0, 2] == 'X' && matrix[1, 2] == 'X' && matrix[2, 2] == 'X')
            {
                Console.WriteLine("                                     ");
                Console.WriteLine("Player 1 wins!");
                Console.WriteLine("                                     ");
                Console.WriteLine("Resetting. Press any key...");
                Console.ReadLine();
                Console.Clear();
                Reset();
            }
            //first diagonal win condition for X.
            else if (matrix[0, 0] == 'X' && matrix[1, 1] == 'X' && matrix[2, 2] == 'X')
            {
                Console.WriteLine("                                     ");
                Console.WriteLine("Player 1 wins!");
                Console.WriteLine("                                     ");
                Console.WriteLine("Resetting. Press any key...");
                Console.ReadLine();
                Console.Clear();
                Reset();
            }
            else if (matrix[0, 2] == 'X' && matrix[1, 1] == 'X' && matrix[2, 0] == 'X')
            {
                Console.WriteLine("                                     ");
                Console.WriteLine("Player 1 wins!");
                Console.WriteLine("                                     ");
                Console.WriteLine("Resetting. Press any key...");
                Console.ReadLine();
                Console.Clear();
                Reset();
            }
        }
        public static void WinO()
        {
            //first horizontal win condition for O.
            if (matrix[0, 0] == 'O' && matrix[0, 1] == 'O' && matrix[0, 2] == 'O')
            {
                Console.WriteLine("                                     ");
                Console.WriteLine("Player 2 wins!");
                Console.WriteLine("                                     ");
                Console.WriteLine("Resetting. Press any key...");
                Console.ReadLine();
                Console.Clear();
                Reset();
            }
            else if (matrix[1, 0] == 'O' && matrix[1, 1] == 'O' && matrix[1, 2] == 'O')
            {
                Console.WriteLine("                                     ");
                Console.WriteLine("Player 2 wins!");
                Console.WriteLine("                                     ");
                Console.WriteLine("Resetting. Press any key...");
                Console.ReadLine();
                Console.Clear();
                Reset();
            }
            else if (matrix[2, 0] == 'O' && matrix[2, 1] == 'O' && matrix[2, 2] == 'O')
            {
                Console.WriteLine("                                     ");
                Console.WriteLine("Player 2 wins!");
                Console.WriteLine("                                     ");
                Console.WriteLine("Resetting. Press any key...");
                Console.ReadLine();
                Console.Clear();
                Reset();
            }
            //first virtical win conditions for O.
            else if (matrix[0, 0] == 'O' && matrix[1, 0] == 'O' && matrix[2, 0] == 'O')
            {
                Console.WriteLine("                                     ");
                Console.WriteLine("Player 2 wins!");
                Console.WriteLine("                                     ");
                Console.WriteLine("Resetting. Press any key...");
                Console.ReadLine();
                Console.Clear();
                Reset();
            }
            else if (matrix[0, 1] == 'O' && matrix[1, 1] == 'O' && matrix[2, 1] == 'O')
            {
                Console.WriteLine("                                     ");
                Console.WriteLine("Player 2 wins!");
                Console.WriteLine("                                     ");
                Console.WriteLine("Resetting. Press any key...");
                Console.ReadLine();
                Console.Clear();
                Reset();
            }
            else if (matrix[0, 2] == 'O' && matrix[1, 2] == 'O' && matrix[2, 2] == 'O')
            {
                Console.WriteLine("                                     ");
                Console.WriteLine("Player 2 wins!");
                Console.WriteLine("                                     ");
                Console.WriteLine("Resetting. Press any key...");
                Console.ReadLine();
                Console.Clear();
                Reset();
            }
            //first diagonal win condition for O.
            else if (matrix[0, 0] == 'O' && matrix[1, 1] == 'O' && matrix[2, 2] == 'O')
            {
                Console.WriteLine("                                     ");
                Console.WriteLine("Player 2 wins!");
                Console.WriteLine("                                     ");
                Console.WriteLine("Resetting. Press any key...");
                Console.ReadLine();
                Console.Clear();
                Reset();
            }
            else if (matrix[0, 2] == 'O' && matrix[1, 1] == 'O' && matrix[2, 0] == 'O')
            {
                Console.WriteLine("                                     ");
                Console.WriteLine("Player 2 wins!");
                Console.WriteLine("                                     ");
                Console.WriteLine("Resetting. Press any key...");
                Console.ReadLine();
                Console.Clear();
                Reset();
            }
        }
        public static void Reset()
        {
            char playerSignX = 'X';
            char playerSignO = 'O';

            switch (playerSignX)
            {
                case 'X':
                    matrix[0, 0] = '1'; matrix[0, 1] = '2'; matrix[0, 2] = '3';
                    matrix[1, 0] = '4'; matrix[1, 1] = '5'; matrix[1, 2] = '6';
                    matrix[2, 0] = '7'; matrix[2, 1] = '8'; matrix[2, 2] = '9'; break;
            };
            switch (playerSignO)
            {
                case 'O':
                    matrix[0, 0] = '1'; matrix[0, 1] = '2'; matrix[0, 2] = '3';
                    matrix[1, 0] = '4'; matrix[1, 1] = '5'; matrix[1, 2] = '6';
                    matrix[2, 0] = '7'; matrix[2, 1] = '8'; matrix[2, 2] = '9'; break;
            };

            inputCorrect = false;
            Console.WriteLine("Press Enter to begin...");
            Console.ReadLine();
            Console.Clear();
            inputCorrect = true;
        }

    }
}
