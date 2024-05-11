// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.InteropServices;

// Console.WriteLine("What is your name?");
// string name = Console.ReadLine();
// Console.WriteLine("Hello " + name);

// System.Console.WriteLine("What is the length of your rectangle?");
// int length = int.Parse(Console.ReadLine());
// // System.Console.WriteLine(length);
// System.Console.WriteLine("What is the width of your rectangle?");
// int width = int.Parse(Console.ReadLine());
// System.Console.WriteLine("The area of your rectangle is " + length * width);

// System.Console.WriteLine("How many miles have you driven?");
// string inputMiles = Console.ReadLine();
// int milesDriven = int.Parse(inputMiles);
// System.Console.WriteLine("How many gallons of gas have you used?");
// string inputGallons = Console.ReadLine();
// int gallons = int.Parse(inputGallons);
// System.Console.WriteLine("You are currently getting " + milesDriven/gallons + " miles per gallon.");

string aliceSentence = """
Alice was beginning to get very tired of sitting by her sister on the
bank, and of having nothing to do: once or twice she had peeped into the
book her sister was reading, but it had no pictures or conversations in
it, 'and what is the use of a book,' thought Alice 'without pictures or
conversation?'
""";
// Console.WriteLine(aliceSentence);
aliceSentence = aliceSentence.ToLower();
System.Console.WriteLine("What word or phrase are you looking for?");

string input = Console.ReadLine();
input = input.ToLower();
System.Console.WriteLine(aliceSentence.Contains(input));
if (aliceSentence.Contains(input)) {
    string aliceMod = aliceSentence.Replace(input, "");
    System.Console.WriteLine(aliceMod);
}