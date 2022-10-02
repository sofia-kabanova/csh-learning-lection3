// цикл while
// string Method4(int count, string text)// строку text компануем count раз
// {
   // int i=0;
    // string result=String.Empty; // изначально пустая строка 
    // while (i<count)
    // {
       // result=result+text;
       // i++;
    // }
    // return result;
// }
// string res = Method4(10, "текст4");
// Console.WriteLine(res);

// Переписываем в цикл for: 

// цикл for
string Method4(int count, string text)// строку text компануем count раз
{
    string result=String.Empty; // изначально пустая строка 
    for (int i = 0; i < count; i++) 
    // инициализация счетчика; проверка счетчика; инкремент
    {
        result=result+text;
    }
    return result;
}
string res = Method4(10, "текст4");
Console.WriteLine(res);

// Цикл в цикле.
// Пример: таблица умножения

for (int i = 0; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}
