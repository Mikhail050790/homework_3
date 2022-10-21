// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите число");
int numX1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int numY1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int numZ1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int numX2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int numY2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int numZ2 = int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(numX1-numX2,2)+Math.Pow(numY1-numY2,2)+Math.Pow(numZ1-numZ2,2));

Console.WriteLine(d);

