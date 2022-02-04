using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero ("MidNigh Blue");//Constructor method
            Zero fx = new Zero ("Black");

            Tesla modelS= new Tesla();
            modelS.MainColor = "Burgundy";//method 2

            Ram silver = new Ram (){MainColor = "Silver"}; // method 3

            Cessna mx410 = new Cessna ();

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();

            fx.Drive();
            fx.Turn();
            fx.Stop();

            modelS.Drive();
            modelS.Turn("squels around a right turn.");
            modelS.Stop("silently stops as if it never moved");

            silver.Drive();
            silver.Turn();
            silver.Stop();

            mx410.Drive();
            mx410.Turn();
            mx410.Stop();

            List<Zero> electricVehicles = new List<Zero> (){fx, fxs}; 
            
        }
    }
}

/*Zero redZero = new Zero(){
         MainColor = "Red"
 };

 same as Zero redZero = newZero();
 Zero.MainColor = "Red";
 */
