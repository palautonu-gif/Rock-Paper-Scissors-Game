namespace Rock_Paper_Scissors_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            // Variable to control the game loop

            bool play = true;

            string player;

            string computer;

            string again;

            while (play)
            {

                //Assign empty strings to the variables

                player = "";
                computer = "";
                again = "";

                while( player !="ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("Enter ROCK,PAPER,SCISSORS=");
                    player = Console.ReadLine()!;
                    player = player.ToUpper();

                }
                int num = random.Next(1, 4);
                switch (num)
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "Paper";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }
                Console.WriteLine("Player=" + player);
                Console.WriteLine("Computer" + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("Draw");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You Lose");
                        }
                        else
                        {
                            Console.WriteLine("You Wins");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You Wins");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("Draw");
                        }
                        else
                        {
                            Console.WriteLine("You Lose");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You Lose");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You Wins");
                        }
                        else
                        {
                            Console.WriteLine("Draw");
                        }
                        break;
                }

                //Again option to play the game

                Console.WriteLine("Do you want to play again? (Y/N)");
                again = Console.ReadLine()!;
                again = again.ToUpper();
                if (again == "Y")
                {
                    play = true;
                }
                else
                {
                    play = false;
                }
            }

            Console.WriteLine("Thank you for playing!");

            Console.ReadLine();
        }
    }
}
