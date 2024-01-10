//var myAge = 40;

using System.Diagnostics.CodeAnalysis;

int myAge = 120;
int newAge = myAge + 5;
//Console.WriteLine(newAge);
int myvar = int.MinValue;
uint myvar2 = uint.MaxValue;
ulong myVar3 = ulong.MaxValue;

// Liczba Zmiennoprzecinkowa;
float myNumber = float.MaxValue;
double myNumber2 = double.MaxValue;

//Zmienna Tekstowa;
string name = "Tomasz";
string surname = "Kondro";
string result = name + surname + myAge;
//Console.WriteLine(result);
char myVar5 = 'c';
var result2 = name.ToArray();

// Zmienna Logiczna;
bool isActive = true;
isActive = false;
var isValid = 5 > 6;
Console.WriteLine(isValid);