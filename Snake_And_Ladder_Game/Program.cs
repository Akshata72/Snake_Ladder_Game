namespace SnakeAndLadderGame
{
    class SnakeAndLadderGame
    {

        static void Main(string[] args)
        {
            int Player_Position = 0;
            Random random = new Random();
            int DiceRoll = random.Next(0, 7);
            Player_Position += DiceRoll;
            Console.WriteLine("Welcome to Snake And Ladder Game...");
            Console.WriteLine("Position of Player = " + Player_Position);
            Console.WriteLine("DiceRoll = " + DiceRoll);
        }


    }







}