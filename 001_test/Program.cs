namespace _001_test
{
    internal class Program
    {
        private enum place
        {
            a,b,c,d,e,f,g,h
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        //char[,] board= new char[9,9];
        char WhiteKing = '\u265A';
            char BlackKing = '\u2654';
            char WhiteQueen = '\u265B';
            char BlackQueen = '\u2655';
            char WhiteBishop = '\u265D';
            char BlackBishop = '\u2657';
            char WhiteKnight = '\u265E';
            char BlackKnight = '\u2658';
            char WhiteRook = '\u265C';
            char BlackRook = '\u2656';
            char WhitePawn = '\u2659';
            char BlackPawn = '\u265F';
            
            for (int i = 0; i<8; i++)                                        //Start of setting background colors
            {
                for (int j = 0; j < 9; j++)
                {
                    if (i == 1 && (j != 0 && j % 2 != 0))
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else if(i == 2 && (j != 0 && j % 2 == 0))
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else if (i == 3 && (j != 0 && j % 2 != 0))
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else if (i == 4 && (j != 0 && j % 2 == 0))
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else if (i == 5 && (j != 0 && j % 2 != 0))
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else if (i == 6 && (j != 0 && j % 2 == 0))
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else if (i == 7 && (j != 0 && j % 2 != 0))
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ResetColor();                                   // End of setting background colors
                    }

                    //--------------------------------------------- putting double spaces into the empty points------------------------

                    if (i == 3 && j !=0)
                    {
                        Console.Write("  ");
                    }
                    if (i == 4 && j != 0)
                    {
                        Console.Write("  ");
                    }
                    if (i == 5 && j != 0)
                    {
                        Console.Write("  ");
                    }
                    //------------------------------------------end---------------------------------

                    if (i == 0 && j > 0)                                              //Characters of destination
                    {
                        Console.Write((place)(j - 1) + " ");
                    }
                    if (j == 0)                                                  // numbers of destination
                    {
                        Console.Write((i+1) + " ");
                    }
                    else if (i == 2 && j != 0)                                    //Black Pawn
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(WhitePawn + " ");
                        Console.ResetColor();
                    }
                    
                    if (i == 1 && j == 1 || i==1 && j==8)                         //Black Rook
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(BlackRook + " ");
                        Console.ResetColor();
                    }
                    if(i == 1 && j==2 || i==1 && j==7)                            //Black Knight
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(BlackKnight + " ");
                        Console.ResetColor();
                    }

                    if (i==1 && j==3 || i==1 && j==6)                             //Black Bishop
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(BlackBishop + " ");
                        Console.ResetColor();
                    }
                    if (i == 1 && j ==4)                                           //Black King
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(BlackKing + " ");
                        Console.ResetColor();
                    }
                    if (i==1 && j==5)                                                   //Black Queen
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(BlackQueen + " ");
                        Console.ResetColor();
                    }
                    //----------------------------------------------------------------White Figures------------------------------------------------
                    if (i == 7 && j == 1 || i == 7 && j == 8)                         //White Rook
                    {
                        Console.ForegroundColor= ConsoleColor.DarkYellow;
                        Console.Write(WhiteRook + " ");
                        Console.ResetColor();
                        
                    }
                    if (i == 7 && j == 2 || i == 7 && j == 7)                            //White Knight
                    {
                        
                        Console.ForegroundColor= ConsoleColor.DarkYellow;
                        Console.Write(WhiteKnight + " ");
                        Console.ResetColor();
                        
                    }
                    if (i == 7 && j == 3 || i == 7 && j == 6)                            //White Bishop
                    {
                        
                        Console.ForegroundColor= ConsoleColor.DarkYellow;
                        Console.Write(WhiteBishop + " ");
                        Console.ResetColor();
                        
                    }
                    if (i == 7 && j == 4)                                                //White King
                    {
                        
                        Console.ForegroundColor= ConsoleColor.DarkYellow;
                        Console.Write(WhiteKing + " ");
                        Console.ResetColor();
                        
                    }
                    if (i == 7 && j == 5)                                                   //White Queen
                    {
                        
                        Console.ForegroundColor= ConsoleColor.DarkYellow;
                        Console.Write(WhiteQueen + " ");
                        Console.ResetColor();
                        
                    }
                    if (i == 6 && j != 0)                                             //White Pawn
                    {
                        Console.ForegroundColor= ConsoleColor.DarkYellow;
                        Console.Write(WhitePawn + " ");
                        Console.ResetColor();
                    }


                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
            
        }
    }
}
