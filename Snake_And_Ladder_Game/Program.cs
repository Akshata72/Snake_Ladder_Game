namespace SnakeAndLadderGame
{
    class SnakeAndLadderGame
    {
       public const int No_Play = 0;
       public const int Ladder_The_Player = 1;
       public const int Snake_The_Player = 2;
        static void Main(string[] args)
        {

            
            int Player_Position = 0;
            Random random = new Random();
            int DiceRoll = random.Next(0, 7);

            Random randomcase = new Random();
            int Position = randomcase.Next(0, 3);
            switch (Position)
            {
                case No_Play:
                    Player_Position = Player_Position;
                    Console.WriteLine("Player No Playing:" + Player_Position);
                    break;

                case Ladder_The_Player:
                    Player_Position += DiceRoll;
                    Console.WriteLine("Ladder The PLayer.");
                    Console.WriteLine("Position of Player = " + Player_Position);
                    Console.WriteLine("DiceRoll = " + DiceRoll);

                    break;

                case Snake_The_Player:
                    Player_Position = Player_Position ;
                    Console.WriteLine("Snake_The_Player.");
                    Console.WriteLine("Position of Player = " + Player_Position);
                    Console.WriteLine("DiceRoll = " + DiceRoll);
                    break;
                   
            }
                
                  
                  

        }


    }







}
