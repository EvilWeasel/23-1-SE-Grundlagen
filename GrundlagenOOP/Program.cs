﻿namespace GrundlagenOOP;
internal class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello, World!"); // Statische-Klasse
    Random rng = new Random(); // Instanziierbare-Klasse
    //Cat myCat = new Cat();
    int x;
    Cat y; // Cat ist unser eigens erstellter Datentyp
    // myCat.Miau();
    // myCat.Name = "Minka";
    // myCat.Age = 10;
    // myCat.Color = "Silver-Tabby";
    // Cat myCoolCat = new Cat();
    // myCoolCat.Color = "Brown";
    // myCoolCat.Age = 12;
    // myCoolCat.Name = "Tom";
    // Console.WriteLine(myCat);
    // Console.WriteLine(myCoolCat);
    // myCoolCat.Name = "Steffan";
    // Console.WriteLine(myCoolCat);

    Cat jerry = new Cat("jerry", 8, "black");
    Console.WriteLine(jerry);
    jerry.Age += 1;

    jerry = new Cat("minka", 12, "silver");

    jerry.Miau();

    Cat.Schnurren();
    Console.WriteLine(jerry);
    Console.ReadLine();


    // fields vs properties
    Dog myDoggo = new Dog(0, "fifi", "white", 3);
    var myDoggo2 = new Dog(1, "susi", "black", 5);
    Dog myDoggo3 = new(2, "maria", "golden", 10);
    myDoggo.Wuff();

    myDoggo.name = "fritz";
    myDoggo.Id = 1;
    Console.WriteLine(myDoggo.Id);
    // myDoggo.Age = 10; -> Init only: nur im Konstruktor
    Console.WriteLine(myDoggo.Age);

    Console.WriteLine("****************");
    Console.WriteLine(myDoggo.Color);
    myDoggo.Color = "yellow";
    Console.WriteLine(myDoggo.Color);
  }
}