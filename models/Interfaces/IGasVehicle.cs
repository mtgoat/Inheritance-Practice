using System;

namespace Garage
{
    public interface IGasVehicle {

        public string Name { get; set;}
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage {get; set;}
        public void RefuelTank()
    {
        // method definition omitted
    }

    }
}