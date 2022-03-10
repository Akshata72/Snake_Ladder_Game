namespace SnakeAndLadderGame
{
    class SnakeAndLadderGame
    {
       public const int Ladder_The_Player = 1;
       public const int Snake_The_Player = 0;
       
        static void Main(string[] args)
        {


             int Final_Position = 100;
             int Player_Position = 0;
             int Num_DiceRoll = 0;

            for( Player_Position =0; Player_Position<=Final_Position;  Player_Position++ )
            {
                Random random = new Random();
                int DiceRoll = random.Next(0, 7);

                Random randomcase = new Random();
                int Position = randomcase.Next(0, 2);

                switch (Position)
                {



                    case Ladder_The_Player:
                        Num_DiceRoll += 1;
                       
                        if (Player_Position > 100)
                        {
                            Player_Position = Player_Position;
                        }
                        else
                        {
                            Player_Position += DiceRoll;
                        }
                        
                        break;


                    case Snake_The_Player:
                        Num_DiceRoll += 1;
                        if (Player_Position < 0)
                        {
                            Player_Position = Player_Position;
                        }
                        else
                        {
                            Player_Position -= Player_Position;

                            
                        }
                        break;

                }
            }
            Console.WriteLine("Number Of Time DiceRoll Throw:" + Num_DiceRoll);
            Console.WriteLine("Position of Player = " + Final_Position);
            Console.WriteLine("Player Gets to Exact Winning Position..");


        }


    }







}
