using System;

Console.Write("Enter the length of the rectangle: ");
string lengthInput = Console.ReadLine();
double length = double.Parse(lengthInput);

Console.Write("Enter the width of the rectangle: ");
string widthInput = Console.ReadLine();
double width = double.Parse(widthInput);

double area = length * width;

Console.WriteLine($"The area of the rectangle is {area}.");
