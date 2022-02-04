using System;

namespace Garage
{
public interface IElectricVehicle{

    public string Name { get; set;}
     public double BatteryKWh { get; set; }

     public void ChargeBattery();
 

    public int CurrentChargePercentage { get; set;} 
   
} 

}