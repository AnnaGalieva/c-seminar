// Задача 22: Найти расстояние между точками в пространстве 2D/3D

//  Формула вычисления расстояния между двумя точками A(xa, ya) и B(xb, yb) на плоскости:
//AB = √(xb - xa)2 + (yb - ya)2
//Формула вычисления расстояния между двумя точками A(xa, ya, za) и B(xb, yb, zb) в пространстве:
//AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2



//int x1 = new Random().Next(0, 10);
//int y1 = new Random().Next(0, 10);
//int z1 = new Random().Next(0, 10);
//Console.WriteLine($"Координаты первой точки:{x1},{y1},{z1}");
//int x2 = new Random().Next(0, 10);
//int y2 = new Random().Next(0, 10);
//int z2 = new Random().Next(0, 10);
//Console.WriteLine($"Координаты второй точки:{x2},{y2},{z2}");
//int A = Math.Abs(x2 - x1);
//Console.WriteLine(A);
//int B = Math.Abs(y2 - y1);
//Console.WriteLine(B);
//int C = Math.Abs(z2 - z1);
//Console.WriteLine(C);

//Console.WriteLine($"Расстояние между точками: {Math.Sqrt(A*A+B*B+C*C)}");


int x1 = new Random().Next(0, 10);
int y1 = new Random().Next(0, 10);
Console.WriteLine($"Координаты первой точки:{x1},{y1}");
int x2 = new Random().Next(0, 10);
int y2 = new Random().Next(0, 10);
Console.WriteLine($"Координаты второй точки:{x2},{y2}");
int A = Math.Abs(x2 - x1);
Console.WriteLine(A);
int B = Math.Abs(y2 - y1);
Console.WriteLine(B);

Console.WriteLine($"Расстояние между точками: {Math.Sqrt(A * A + B * B)}");
