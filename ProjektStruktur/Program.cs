﻿using MyCalculator;
using ProjektStruktur.Models;
using System.Collections.Generic;
namespace ProjektStruktur
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World!");
      var num1 = 10;
      var num2 = 20;

      var addResult = Calculator.Add(num1, num2);
      Console.WriteLine(addResult);

      // var x = Bikes....
    }
  }
}