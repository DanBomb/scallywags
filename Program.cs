using System;

namespace scallywags
{
    class Program
    {
        static void Main(string[] args)
        {

            int userInput = 0;
            bool gamePlay = false;
            Ship enemy = new Ship(2, "Spanish Sloop");
            Player me = new Player();            
            Combat battle1 = new Combat(me.player, enemy);

            Console.WriteLine("Press spacebar to begin the game");
            Console.ReadKey();
            gamePlay = true;
            Console.WriteLine();
            Console.WriteLine("Welcome to Scallywags!");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine();
            Console.WriteLine("Ad-hoc deck of size 5 Demo");

            while(me.CanDraw()){
                me.DrawCard();
            }

            while (gamePlay == true)
            {
                Console.WriteLine(userInput);
                Console.WriteLine("Please choose an option:");
                //Console.WriteLine("Move - m");
                //Console.WriteLine("Play card - p");
                Console.WriteLine("Attack - a");
                Console.WriteLine("View Hand - v");
                Console.WriteLine("Quit Game - q");
                Console.WriteLine(userInput);
                userInput = Console.Read();
                Console.WriteLine(userInput);
                /* if (userInput = "p")
                {
                    me.PlayCard();
                }*/ 
                //Console.WriteLine("test");
                //Console.WriteLine(userInput);
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
                else if (userInput == 97)
                {
                    Console.WriteLine("You initiated combat.");
                    System.Threading.Thread.Sleep(1000);
                    battle1.Start(me.player.Description(), enemy.Description());
                    System.Threading.Thread.Sleep(3000);
                }
            }
        }
    }
}
