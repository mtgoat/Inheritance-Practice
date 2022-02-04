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

    public virtual void Turn()
    {
        Console.WriteLine("The vehicle carefully turns right.");
    }
    
    public virtual void Turn(string direction)
    {
        Console.WriteLine($"{direction}.");
    }
    public virtual void Stop()
    {
        Console.WriteLine("The vehicle gently rolls to a stop!\n");
    }

    public virtual void Stop(string direction)
    {
        Console.WriteLine($"{direction}");
    }
  

}


}
//method overloading - which method to call based on a type of parameter