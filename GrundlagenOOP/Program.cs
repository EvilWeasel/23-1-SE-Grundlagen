namespace GrundlagenOOP;
internal class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello, World!"); // Statische-Klasse
    Random rng = new Random(); // Instanziierbare-Klasse
    Cat myCat = new Cat();
    myCat.Miau();
    Cat.Miau();
  }
}