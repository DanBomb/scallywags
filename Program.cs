using System;

namespace scallywags
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ad-hoc deck of size 10 Demo");
            Player me = new Player();
            while(me.CanDraw()){
                me.DrawCard();
            }
            me.DrawCard();
        }
    }
}
