using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Golf
{
    class Program
    {
        public static double Ball = -1000;
        public static int Goal = 0;
        
        
        public static void Main(string[] args)
        {
            Swing swing = new Swing();
            Cup cup = new Cup();
            while (Ball != Goal)
            {
                Console.Clear();
                cup.Show();
                swing.Hit();
                swing.Power();
                swing.Dist();
            }
            Console.WriteLine("\nYou Won!");
            Console.ReadKey();
        }
    }
}
