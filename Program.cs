using System;

namespace scallywags
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Press spacebar to begin the game");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Welcome to Scallywags!");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine();
            Console.WriteLine("Ad-hoc deck of size 10 Demo");
            Player me = new Player();
            while(me.CanDraw()){
                me.DrawCard();
            }
            //me.DrawCard();
                
        }
    }
}
