using System;
using System.Collections.Generic;

namespace Garage
{ 
class Program
    {
        static void Main (string[] args)
        {
         

            Zero fxs = new Zero("White"){
                Name = "fxsZero",
                CurrentChargePercentage = new Random().Next(0, 100)
            };
            Zero fx = new Zero("Black"){
                Name ="fxZero",
                CurrentChargePercentage = new Random().Next(0, 100)
            };
            Tesla modelS = new Tesla(){
                Name ="modelS",
                CurrentChargePercentage = new Random().Next(0, 100)
            };

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"The {ev.Name} has charged {ev.CurrentChargePercentage}%.");
            }//show the percent of current

            Console.WriteLine("-----charging----");
            foreach(IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
                
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"The {ev.Name} has charged {ev.CurrentChargePercentage}%.");
            }

            //{ev.Name} = {this.GotType().Name}
            /***********************************************/

            Ram ram = new Ram (){
                CurrentTankPercentage = new Random().Next(0, 100),
                Name = "ram"
            };

            Cessna cessna150 = new Cessna (){
                CurrentTankPercentage = new Random().Next(0, 100),
                Name = "cessna150"
            };

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
            };

            Console.WriteLine("\n Gas Vehicles");
            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"The {gv.Name} has charged {gv.CurrentTankPercentage}%.");
            }

            Console.WriteLine("-----refueling----");

            foreach(IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
                
            }

            foreach(IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"The {gv.Name} has charged {gv.CurrentTankPercentage}%.");
            }
        }
    }

}
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Zero fxs = new Zero ("MidNigh Blue");//Constructor method
//             Zero fx = new Zero ("Black");

//             Tesla modelS= new Tesla();
//             modelS.MainColor = "Burgundy";//method 2

//             Ram silver = new Ram (){MainColor = "Silver"}; // method 3

//             Cessna mx410 = new Cessna ();

//             fxs.Drive();
//             fxs.Turn();
//             fxs.Stop();

//             fx.Drive();
//             fx.Turn();
//             fx.Stop();

//             modelS.Drive();
//             modelS.Turn("squels around a right turn.");
//             modelS.Stop("silently stops as if it never moved");

//             silver.Drive();
//             silver.Turn();
//             silver.Stop();

//             mx410.Drive();
//             mx410.Turn();
//             mx410.Stop();

//             List<Zero> electricVehicles = new List<Zero> (){fx, fxs}; 
            
//         }
//     }


// /*Zero redZero = new Zero(){
//          MainColor = "Red"
//  };

//  same as Zero redZero = newZero();
//  Zero.MainColor = "Red";
//  */
