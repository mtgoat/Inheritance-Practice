using System;

namespace Garage
{

    //inheritance 
    //Base Class (parent) - the class being inherited from
    public class Vehicle
{
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }



// by adding virtual to the base class, it allows derived classes to override 
        public virtual void Drive()
    {
        Console.WriteLine("Vrooom!");
    }
}


}