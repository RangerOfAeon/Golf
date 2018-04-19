using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf
{
    class Swing
    {
        //Program program = new Program();
        Cup cup = new Cup();
        
        double Angle;
        double OutVelo;

        public void Hit()
        {
            Console.WriteLine("\nAt which angle do you want to swing?");

            double OutAngle;
            bool What = false;

            while (What == false)
            {
                string InAngle = Console.ReadLine();
                if (double.TryParse(InAngle, out OutAngle) && OutAngle != 0)
                {
                    Angle = (Math.PI / 180) * OutAngle;
                    Console.WriteLine("\nYour radians is: " + Angle);
                    What = true;
                }
                else if(!double.TryParse(InAngle, out OutAngle))
                {
                    Console.WriteLine("\nThat's not a number, try again.");
                }
                else if(OutAngle == 0)
                {
                    Console.WriteLine("\nThe angle can't be 0, try again.");
                }
               
            }
        }
        public void Power()
        {
            Console.WriteLine("\nHow much velocity do you want?");
            
            bool What = false;

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
        public void Dist()
        {
            double Distance = Math.Pow(OutVelo, 2) / 9.8 * Math.Sin(2 * Angle);
            Cup.OutDist = Math.Round(Distance);

            if (Program.Ball < Program.Goal)
            { 
                Program.Ball = Program.Ball + Cup.OutDist;
                Console.WriteLine("\nYour ball went: " + Cup.OutDist + " Meters.");
                Console.WriteLine("\nYou have: " + Program.Ball + " meters to the cup.");
                Cup.Count = Cup.Count + 1;
                Console.ReadKey();
            }
            else if(Program.Ball > Program.Goal)
            {
                Program.Ball = Program.Ball - Cup.OutDist;
                Console.WriteLine("\nYour ball went: " + Cup.OutDist + " Meters.");
                Console.WriteLine("\nYou have: " + Program.Ball + " meters to the cup.");
                Cup.Count = Cup.Count + 1;
                Console.ReadKey();
            }
        }
    }

}
