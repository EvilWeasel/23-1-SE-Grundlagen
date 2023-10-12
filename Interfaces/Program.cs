var objectList = new List<IFlyable>();

objectList.Add(new Bird());
objectList.Add(new Bird());
objectList.Add(new Airplane());

var driveables = new List<IDriveable>();
driveables.Add(new Car());
driveables.Add(new Car());
driveables.Add(new Airplane());

var randomPlane = new Airplane();

foreach (var item in objectList)
{
  item.Fly();
}

foreach (var item in driveables)
{
  item.Drive();
}

public class Bird : IFlyable
{
  public void Fly()
  {
    Console.WriteLine("Der Vogel fliegt");
  }
}

public class Airplane: IFlyable, IDriveable
{
  public void Drive()
  {
    Console.WriteLine("Das Flugzeug fährt");
  }

  public void Fly()
  {
    Console.WriteLine("Das Flugzeug fliegt");
  }
}

public class Car : IDriveable
{
  public void Drive()
  {
    Console.WriteLine("Das Auto Fährt");
  }
}

public class Hovercraft : ISwimable, IDriveable
{
  public void Drive()
  {
    Console.WriteLine("Hovercraft fährt!");
  }

  public void Swim()
  {
    Console.WriteLine("Hovercraft schwimmt!");
  }
}

public class Boot : ISwimable
{
  public void Swim()
  {
    Console.WriteLine("Das Boot schwimmt!");
  }
}