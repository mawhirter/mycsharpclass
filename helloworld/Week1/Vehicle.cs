using System;

public class Vehicle
{
    //Reference type Field
    //Private variables should use an underscore
    private string  _color;

    //Normal Property
    public string Color 
    {
        get
        {
            return _color;
        }
        set
        {
            Console.WriteLine(value);
            this._color = value;
        }
    }
    //Automatic Property
    public string WheelType { get; set;}

//default constructor

public Vehicle() 
{
Console.WriteLine("Default Constructor");

}
 
 public Vehicle(string type)  //constructor with a parameter
 {
    Console.WriteLine(type);


 }
    public void OpenDoor() //Method with no parameters
    {
     Console.WriteLine("Door is Open");

    }
public virtual void CloseWindow()
    {
        Console.WriteLine("Vehicle Window Closed");
    }



}




