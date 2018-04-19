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
        public static int Edge = 200;
        //Swing swing = new Swing();

       /* public void LoseCount()
        {


            // throw new Exception
            // {
            //     try
            //      {
            //
            //      }
            // }

        }
        public void LoseEdge()
        {


            if (Program.Ball >= Edge)
            {
                throw new Exception("The ball fell of the map");
            }
        }
        */
        public void Show()
        {
            Console.WriteLine("\nYou have: " + Program.Ball + " Meters left to the cup.");
            Console.WriteLine("\nYou have swung: " + Count + " times, max is 10");
        }
    }
}
  
    
   

