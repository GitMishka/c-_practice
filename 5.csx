using System;

Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());

int a = 0;
int b = 1;
int temp;

Console.WriteLine("Fibonacci sequence up to " + num + ":");

while (a <= num)
{
    Console.Write(a + " ");
    temp = a;
    a = b;
    b = temp + b;
}
