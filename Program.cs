using System;

namespace scallywags
{
    class Program
    {
        static void Main(string[] args)
        {

            int userInput;
            bool gamePlay = false;

            Console.WriteLine("Press spacebar to begin the game");
            Console.ReadKey();
            gamePlay = true;
            Console.WriteLine();
            Console.WriteLine("Welcome to Scallywags!");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine();
            Console.WriteLine("Ad-hoc deck of size 10 Demo");
            Player me = new Player();
            while(me.CanDraw()){
                me.DrawCard();
            }

            while (gamePlay == true)
            {
                userInput = 0;
                Console.WriteLine("Please choose an option:");
                //Console.WriteLine("Move - m");
                //Console.WriteLine("Play card - p");
                //Console.WriteLine("Attack - a");
                Console.WriteLine("View Hand - v");
                Console.WriteLine("Quit Game - q");
 
                userInput = Console.Read();
                /* if (userInput = "p")
                {
                    me.PlayCard();
                }*/ 
                Console.WriteLine("test");
                Console.WriteLine(userInput);
                if (userInput == 118)
                {
                Console.WriteLine("You chose: View Hand");
                System.Threading.Thread.Sleep(1000);
                me.ShowHand();
                }
                else if (userInput == 113)
                {
                    gamePlay = false;
                }
                else if (userInput == 0)
                {
                    Console.WriteLine("testing");
                }
            }
        }
    }
}
