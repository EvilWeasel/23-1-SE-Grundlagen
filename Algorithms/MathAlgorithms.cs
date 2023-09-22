using System.Runtime.InteropServices;

namespace Algorithms;

public static class MathAlgorithms 
{
    public static int Factorial(int n)
    {
        var i = n;
        while (i > 1)
        {
            i--;
            n = n * i;
        }
        return n;
    } 
    public static int FactorialFor(int n)
    {
        for (int i = 1; i < n; i++)
        {
            n = n * i;
        }
        return n;
    }
} 

public class Cat 
{
    void Miau()
    {
        Console.WriteLine("miau");
    }
    static void Schnurr()
    {

    }
}

var cat1 = new Cat();

cat1.Miau()

Cat.Schnurr()