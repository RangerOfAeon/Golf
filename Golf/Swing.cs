using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf
{
    class Swing
    {
        Cup cup = new Cup();                                         // Här gör jag en instance av Cup-klassen.
        
        double Angle;                                                // Här är två variabler som jag använder i Dist, så jag har dom utanför deras respektiva metoder.
        double OutVelo;                                                 

        public void Hit()
        {
            Console.WriteLine("\nAt which angle do you want to swing?");        // Här är metoden som frågar från vilken vinkel spelaren vill skjuta ifrån. Jag
                                                                                // börjar en loop som fortsätter tills man har skrivit in ett nummer som är större 0.
            double OutAngle;                                            
            bool What = false;

            while (What == false)
            {
                string InAngle = Console.ReadLine();
                if (double.TryParse(InAngle, out OutAngle) && OutAngle != 0)      // Om spelaren har skrivit in ett nummer som är större än 0, så räknar konsolen och   
                {                                                                 // skriver ut radiansen av vinkeln, sen fortsätter den till nästa metod.
                    Angle = (Math.PI / 180) * OutAngle;
                    Console.WriteLine("\nYour radians is: " + Angle);
                    What = true;
                }
                else if(!double.TryParse(InAngle, out OutAngle))                   // Om man skriver in något som inte är ett nummer, så skriver konsolen att man får
                {                                                                  // pröva igen, sedan loopar den tillbaka.
                    Console.WriteLine("\nThat's not a number, try again.");
                }
                else if(OutAngle == 0)                                             // Likadan som if-satsen innan, fast med en 0 istället för icke-nummer.
                {
                    Console.WriteLine("\nThe angle can't be 0, try again.");
                }
               
            }
        }
        public void Power()
        {
            Console.WriteLine("\nHow much velocity do you want?");                      // Här börjar metoden som frågar vilken velocity spelaren vill ha, den är 
                                                                                        // nästan likadan, fast den räknar inte ut något, som Hit-metoden gör med
            bool What = false;                                                          // radians.

            while(What == false)
            {
                string InVelo = Console.ReadLine();                         
                if(double.TryParse(InVelo, out OutVelo) && OutVelo != 0)
                {
                    Console.WriteLine("\nYour velocity is: " + OutVelo);
                    What = true;
                }
                else if(!double.TryParse(InVelo, out OutVelo))
                {
                    Console.WriteLine("\nThat's not a number, try again.");
                }
                else if(OutVelo == 0)
                {
                    Console.WriteLine("\nThe velocity can't be 0, try again.");
                }
            }
        }
        public void Dist()                                                                      // Här börjar metoden som räknar ut distansen som golfbollen åker.
        {
            double Distance = Math.Pow(OutVelo, 2) / 9.8 * Math.Sin(2 * Angle);                 // Här räknar konsolen ut distansen, och avrundar den till närmaste int.
            Cup.OutDist = Math.Round(Distance);
                                                                                                // Här kollar konsolen om målet är framför spelaren, eller bakom, och                                                                                              
            if (Program.Ball < Program.Goal)                                                    // ändrar vinkeln om spelaren är bakom.
            {                                                                                   
                Program.Ball = Program.Ball + Cup.OutDist;                                      // Här flyttar konsolen på golfbollen, och skriver hur långt den flög, 
                Console.WriteLine("\nYour ball went: " + Cup.OutDist + " Meters.");             // hur långt det är kvar till målet och lägger till ett slag till 
                Console.WriteLine("\nYou have: " + Program.Ball + " meters to the cup.");       // spelarens totalslag.
                Cup.Count = Cup.Count + 1;
                Console.ReadKey();
            }
            else if(Program.Ball > Program.Goal)
            {
                Program.Ball = Program.Ball - Cup.OutDist;                                      // Likadant som innan, fast den skjuter tillbaka om spelaren är bakom 
                Console.WriteLine("\nYour ball went: " + Cup.OutDist + " Meters.");             // målet.
                Console.WriteLine("\nYou have: " + Program.Ball + " meters to the cup.");
                Cup.Count = Cup.Count + 1;
                Console.ReadKey();
            }
        }
    }

}
