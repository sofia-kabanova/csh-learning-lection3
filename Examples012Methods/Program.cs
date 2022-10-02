// Вид 1-ничего не принимают и ничего не возвращают
void Method1() //создаем метод
{
    Console.WriteLine ("Автор я )) "); // метод, который, например6 указывает автора
}
Method1();// вызываем метод 


// Вид 2-ничего не возвращают, но могут принимать какие-то аргументы.
void Method2(string msg) // создаем метод
{
    Console.WriteLine(msg);
}
Method2 ("Текст сообщения"); // вызываем метод

void Method21(string msg, int count) // создаем метод
{
    int i = 0 ;
    while (i < count)
    {
        Console.WriteLine(msg);
        //count ++; // ошибка, программа зациклится, чтобы остановить нажимаем
        // control+c
        i++;
    }
}
// Method21("Текст", 4);// вызываем или с указанием, что присваеватся аргументам:
Method21(msg : "Текст", count: 4);//-именованные аргументы, можно
// можно писать в любом порядке:
// Method21(count: 4, msg : "Текст");


//  Вид 3- что-то возвращают, но ничего не принимают
int Method3() //метод 
//необходимо указать тип данных, которые будут возвращены
{
    return DateTime.Now.Year;// работа метода
}
int year = Method3();//сюда кладем результат работы метода
// через оператор присваивания (=)
Console.WriteLine(year);// используем переменную и значение,
// которое вернул метод

// Вид 4- методы, которые что-то принмают и что-то возвращают
string Method4(int count, string text)// строку text компануем count раз
{
    int i=0;
    string result=String.Empty; // изначально пустая строка 
    while (i<count)
    {
        result=result+text;
        i++;
    }
    return result;
}
string res = Method4(10, "текст4");
Console.WriteLine(res);

