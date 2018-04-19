using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Golf
{
    class Cup
    {
        public static int Count = 0;
        public static double OutDist;
        List<double> AllSwings = new List<double>(); 
       
        public void TooMany()
        {
            if (Count >= 11) throw new Exception("You went over the max.");
        }

        public void Edge()
        {
            if (Program.Ball >= 500) throw new Exception("You went over the edge.");
        }

        public void AddSwing()
        {
            AllSwings.Add(OutDist);
        } 
        public void ShowSwings()
        {
            Console.WriteLine("\nYou Won!");
            Console.WriteLine("\nHow many swings you took: " + Count);
            Console.WriteLine("\nHow much you traveled with each swing:");
            foreach (int item in AllSwings)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public void Show()
        {
            Console.WriteLine("\nYou have: " + Program.Ball + " Meters left to the cup.");
            Console.WriteLine("\nYou have swung: " + Count + " times, max is 10");
        }

    }
}
  
    
   

