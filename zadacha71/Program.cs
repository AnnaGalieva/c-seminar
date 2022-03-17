// Задача 73 : Есть число N. Сколько групп M, можно получить при разбиении всех 
//чисел на группы, так чтобы в одной группе все числа были взаимно просты 
//(все числа в группе друг на друга не делятся)? Найдите M при заданном N и 
//получите одно из разбиений на группы N ≤ 10²⁰.
//Например, для N = 50, M получается 6

/*Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
int m = (int)Math.Log2(n)+1;
Console.WriteLine($"числа до {n} разбиваются на {m} групп");
Console.WriteLine($"Группа 1:   1.");

for (int i = 1; i < m-1; i++)
{
        Console.WriteLine($"Группа {i+1}: от {Math.Pow(2, i)} до {Math.Pow(2, i+1)-1}");
    }
Console.WriteLine($"Группа {m}: от {Math.Pow(2, m-1)} до {n}" );*/

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
int group = 0;
for (int i = 1; i < n; i++)
{
    if (i == Math.Pow(2, group))
    {
        Console.WriteLine();
        group++;
        Console.Write($"Группа {group}: ");
    }
    Console.Write($"{i} ");
}
Console.WriteLine();
Console.WriteLine();