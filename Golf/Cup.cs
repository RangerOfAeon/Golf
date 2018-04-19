using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Golf
{
    class Cup
    {
        public static int Count = 0;                                    // Här har jag variabler som används i flera metoder, och en list som har distansen varje 
        public static double OutDist;                                   // slag har flugit.
        List<double> AllSwings = new List<double>(); 
       
        public void TooMany()           // Här kollar konsolen om spelaren har slagit golfbollen för många gånger, och kastar en exceptio till spelaren.
        {
            if (Count >= 11) throw new Exception("You went over the max.");
        }

        public void Edge()              // Här kollar konsolen om spelaren har slagit golfbollen för långt fram eller bak, och kastar en exception till spelaren.
        {
            if (Program.Ball >= 500 || Program.Ball <= -1500) throw new Exception("You went over the edge.");  
        }

        public void AddSwing()          // Här så lägger konsolen in det senaste slaget som spelaren har skjutit i listan. 
        {
            AllSwings.Add(OutDist);
        } 
        public void ShowSwings()
        {
            Console.WriteLine("\nYou Won!");                                        // Här visar konsolen att spelaren van, hur många gånger den behövde slagit, och 
            Console.WriteLine("\nHow many swings you took: " + Count);              // hur lång distans den flög varje gång.
            Console.WriteLine("\nHow much you traveled with each swing:");
            foreach (int item in AllSwings)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public void Show()
        {
            Console.WriteLine("\nYou have: " + Program.Ball + " Meters left to the cup.");   // Här visar konsolen hur långt kvar spelaren har kvar till målet, och
            Console.WriteLine("\nYou have swung: " + Count + " times, max is 10");           // hur måga gånger den har slagit golfbollen.
        }

    }
}
  
    
   

