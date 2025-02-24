// See https://aka.ms/new-console-template for more information
using System.Collections;

int a= 0;
int b= 0;
int c= 0;

Console.WriteLine("Insira um número:" );
a=int.Parse(Console.ReadLine());

Console.WriteLine("Insira um número:" );
b=int.Parse(Console.ReadLine());

c=a+b;

Console.WriteLine($"Seu resultado é:" + c);