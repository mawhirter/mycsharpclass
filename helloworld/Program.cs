using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Vehicle vehicle = new Vehicle();

            vehicle.Color = "Blue";
            vehicle.WheelType = "Chrome";
            Console.WriteLine(vehicle.WheelType);

            Vehicle myVehicle = new Vehicle();
            myVehicle.Color = "Red"; //sets the color to red
            myVehicle.OpenDoor();
            
        Car myCar = new Car();
        myCar.Color = "Green";
        myCar.CloseWindow();
        
        }
    }
}
 