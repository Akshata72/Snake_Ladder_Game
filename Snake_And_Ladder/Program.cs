using System;
namespace SnakeAndLadder
{

    class SnakeAndLadder
    {

        
        static void Main(string[] args)
        {
            
            int  Position_PlayerOne = 0;
            int Position_PlayerTwo = 0;
            int Final_Position = 100;

            while (Position_PlayerOne != Final_Position && Position_PlayerTwo != Final_Position)
            {
                Random random = new Random();
                int RollDice_Player = random.Next(0, 7);
                int Option_Player = random.Next(0, 3);
                int Player_Turn = random.Next(0, 2);
                if (Player_Turn == 0)
                { 
               

                        switch (Option_Player)
                        {
                            case 0:

                                Position_PlayerOne += RollDice_Player;
                            if (Position_PlayerOne == Final_Position)
                            {
                                Console.WriteLine("Player One Winn the Game.." + Position_PlayerOne);
                            }
                            break;

                            case 1:
                                Position_PlayerOne -= RollDice_Player;
                                break;

                        default:
                                Position_PlayerOne = Position_PlayerOne;
                                break;

                        }

                    

                }

                else
                {

                    int RollDice_PlayerTwo = random.Next(0, 7);
                    int Option_PlayerTwo = random.Next(0, 3);


    
                        switch (Option_PlayerTwo)
                        {
                            case 0:

                                Position_PlayerTwo += RollDice_PlayerTwo;
                            if (Position_PlayerTwo == Final_Position)
                            {
                                Console.WriteLine("Player Two Winn the Game.." + Position_PlayerTwo);
                            }
                            break;

                            case 1:
                                Position_PlayerTwo -= RollDice_PlayerTwo;
                                break;

                            default:
                                Position_PlayerTwo = Position_PlayerTwo;
                                break;

                        }


                    









                }


                


                
                

              
                       

                    














                    






                




            }



















        }

    }
}
        
             


        

    


