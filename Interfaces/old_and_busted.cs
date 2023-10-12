namespace old_and_busted;
//var flyingThing = new FlyableObject();
//flyingThing.Fly();
//var myBird = new Bird();
//myBird.Fly();

//var myCar = new Car();
//myCar.Drive();

public class FlyableObject
{
  public void Fly()
  {
    Console.WriteLine("Das Ding fliegt...");
  }
}

public class DriveableObject
{
  public void Drive()
  {
    Console.WriteLine("Das Ding fährt");
  }
}

public class Bird : FlyableObject
{
  //public void Fly()
  //{
  //  Console.WriteLine("Der Vogel fliegt...");
  //}
}
// Mehrfachvererbung ist in C# NICHT erlaubt!
public class Airplane : FlyableObject//, DriveableObject
{
  //public void Fly()
  //{
  //  Console.WriteLine("Das Flugzeug fliegt...");
  //}
}

public class Car : DriveableObject
{

}