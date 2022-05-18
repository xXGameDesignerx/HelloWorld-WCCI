// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Variable explanation
// What is a variable?
// named object/values that can change
//variablke are named objects with values and types
//built-in types: string, int, double, boolean
// String = text, int = whole numbers, double = decimals, boolean = true/false


// variable declaration is creating a variable
// variableType variableName;
string instructor; // this variable is null (no value)

//variable assignment is giving a variable a value
// variableName = value;
instructor = "davis"; // instructor has a value of davis (setting)
instructor = "gavin";

instructor = "gavin" + "davis";

Console.WriteLine(instructor); // instructor has a vaule of gavin

string coInstructor = "gavin";
int studentCount = 8;

// declaring a variable and assigning variable
string input = Console.ReadLine();
Console.WriteLine(input);

// operators are ways we can manipulate values/variables
// ex: addition (+) 5 + 5 = 10
float num = 5 + 5;
Console.WriteLine(num);
Console.WriteLine(num == 10);
num = 5 * 5;
num = 5 / 5;
num = 5 / 3f;
Console.WriteLine(num);

// visual variable type cues
// quotes "" = -> string
// d,D, 0.0 -> double
//f,F -> float
// m,M -> deciMal
// true, false -> bollean
//number -> int
// single quotes '' -> char
