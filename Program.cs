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
            fx.Drive();
            modelS.Drive();
            mx410.Drive();

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
