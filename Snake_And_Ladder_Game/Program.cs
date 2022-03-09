namespace SnakeAndLadderGame
{
    class SnakeAndLadderGame
    {

        static void Main(string[] args)
        {
            int Start_Player_Position = 0;
            Random random = new Random();
            int DiceRoll = random.Next(0, 7);
            Console.WriteLine("Welcome to Snake And Ladder Game...");
            Console.WriteLine("Starting Position of Player = " + Start_Player_Position);
            Console.WriteLine("DiceRoll = " + DiceRoll);
        }


    }







}