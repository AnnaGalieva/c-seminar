// 74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в».
// Покажите все слова, состоящие из n букв, 
//которые можно построить из букв этого алфавита

/*string alf = "аисв";
int n = 3;  // кол букв
string[] Words(string a, int num);
{
    if (num == 0)
    {
        //string[] resul = {" "};        
        return new string[]{""};
    }
    string[] w = Words(a, num - 1);
    string[] result = new string[w.Length * 4];
    int k = 0;
    for (int i = 0; i < w.length; i++)
    {
        for (int j = 0; j < a.length; j++)  //перебираем алфавит
        {
            result[k] = w[i] + a[j];
            k++;
        }
    }
    return result;
}

string[] res = Words(alf, n);
for (int i = 0; i < res.length; i++)
{
    Console.Write(res[i] + "");
}*/
string alf = "аисв";
int n = 3;
string[] Words(string a, int num)
{
    if (num == 0)
    {
        string[] resul = { "" };
        return resul;
    }
    string[] w = Words(a, num - 1);
    string[] result = new string[w.Length * 4];
    int k = 0;
    for (int i = 0; i < w.Length; i++)
    {
        for (int j = 0; j < a.Length; j++)
        {
            result[k] = w[i] + a[j];
            k++;
        }
    }
    return result;
}
string[] res = Words(alf, n);
for (int i = 0; i < res.Length; i++)
{
    Console.Write(res[i] + " ");
}


//3
Console.WriteLine("Введите число1 N: ");
int num = int.Parse(Console.ReadLine());
String symbols = "аисв";
int n = 1;
void FindWords(string alfavit, char[] word, int Length = 0);
{
    if (Length == word.Length)
    {
        Console.WriteLine($"{n++} {new string(world)}");
        return;
    }
    for (int i = 0; i < alfavit.length; i++)
    {
        word[Length] = alfavit[i];
        FindWords(alfavit, word, Length + 1);

    }
}
FindWords(symbols, new char[num]);
