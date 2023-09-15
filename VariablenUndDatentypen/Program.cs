#region Variablen
// Variablen Deklaration

string name;
int age;
object random;
float height;
// Variablen sind erst nach einer Deklaration verwendbar

//Console.WriteLine(age); => Funktioniert erst nach der Initialisierung

// Variablen Initialisierung / Assignment
name = "Default";
age = 0;
random = new object();
height = 0.0f;

// Deklaration und Initialisierung
int abc = 42;
string hello = "Hello";
var blubb = Console.ReadLine();

int i = 0;
while (i<5)
{
  var xyz = 10;
  Console.WriteLine(hello);
  i++;
} // Wenn ein Codeblock geschlossen wird, sind alle Variablen die innerhalb des Blocks deklariert wurden nicht mehr gültig => Können danach nicht mehr verwendet werden.

// xyz => Geht nicht, da xyz in anderem Scope ist
// var xyz = 20; => Variable kann dafür aber neu deklariert werden

#endregion

#region Primitive-Datentypen
// Primitive Datentypen => Werte-Typen, Value-Types
bool boolean = false || true;
int ganzzahl = 200;
// ganzzahl = 500;
// Int16 test = 0; => Würde man nie in der Praxis verwenden, der "normale" int ist dynamisch...
float width = 1.0f;
double depth = 1.0d;
decimal moneten = 900000000.627m;
var testfloat = 1.0m;
char sign = '+';
char letter = 'B';
#endregion

#region Komplexe-Datentypen
// Komplexe-Typen => Referenz-Typen
object myObject = new object();
string greeting = "Hello World!";
// dynamic myDynamic;
#endregion

#region WerteVsReferenz-Typen
int num1 = 10;

int[] array1 = { 1, 2, 3 };

Console.WriteLine("Vor Modify");
Console.WriteLine("num1: " + num1);
Console.WriteLine("array1: " + string.Join(',', array1));
// num1 = 10
// array[0] = 1
Modify(num1, array1);
// num1 = 10
// array[0] = 100
Console.WriteLine("Nach Modify");
Console.WriteLine("num1: " + num1);
Console.WriteLine("array1: " + string.Join(',', array1));


void Modify(int num, int[] array)
{
  num = 100;
  array[0] = 100;
}
#endregion




