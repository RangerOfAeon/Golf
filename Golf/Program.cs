using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Golf
{
    class Program
    {
        public static double Ball = -1000;                              // Här har variablerna som är golfbollen som flyttas, och målet
        public static int Goal = 0;                                     // som spelaren försöker nå.
        
        
        
        public static void Main(string[] args)
        {
            Swing swing = new Swing();
            Cup cup = new Cup();
            while (Ball != Goal)                                        // Här börjar loopen som fortsätter till spelaren har antingen
            {                                                           // vunnit eller kommit till en exception.
                Console.Clear();
                cup.TooMany();
                cup.Edge();                                             // Här kallar konsolen på all metoder, och dom börjar med att kolla om spelaren har lyckats 
                cup.Show();                                             // misslyckas genom att slagit för mycket eller för långt, sedan visar konsolen hur långt det 
                swing.Hit();                                            // är kvar och hur många gånger spelaren har skjutit. 
                swing.Power();
                swing.Dist();                                           // Sedan frågar konsolen om vinkeln och velocity, och räknar ut distansen utav det, och lägger
                cup.AddSwing();                                         // slaget i listan. Den fortsätter tills man har lyckats, och då får man se hur måga gånger det
            }                                                           // tog, och hur långt man åkte med varje slag.
            Console.Clear();
            cup.ShowSwings();
        }
    }
}
