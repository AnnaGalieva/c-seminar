// 42. Определить сколько чисел больше 0 введено с клавиатуры.

int volume = 3;                // сколько вводится чисел
int count = 0;

while (volume > 0)
{
    Console.Write("Введите число:   ");
    string num = Console.ReadLine();
    int number = int.Parse(num);
    if (number > 0) count++; volume--;
}

Console.WriteLine($"чисел больше 0: {count}");

//string[] str = Console.Readline().Split(' ');
for (int i = 0; i < str.Length; i++)
{
    int num = int.Parse(str[i]);
    Console.WriteLine("num");
}