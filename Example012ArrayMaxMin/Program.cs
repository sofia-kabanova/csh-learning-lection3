//Задача:
// 1. Найти позицию макс позицию элемента в неотсортированной части массива.
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции.
// 3. Повторять пока есть неотсортированные элементы.
// Было:18326457
// Результат: 87654321

int[] arr={1, 5, 4, 3, 2, 6, 7, 1, 1}; // вводим массив
// подзадача вывести данный массив на экран
void PrintArray(int[] array)// метод, аргумент - массив
//метод, который вывод массив на экран
{
    int count = array.Length; // кол-во элементов массива=длинна массива
    for (int i=0; i<count; i++)// цикл, пробегаем по всем элементам
    {
        Console.Write($"{array[i]} ");//выводим массив на экран
    }
    Console.WriteLine(); // пустая строка
}
void SelectionSort(int[] array)// метод,  аргумент - массив
// метод, который упорядочивает массив
{
    for (int i = 0; i < array.Length-1; i++)//цикл
    // пробегаем по всем элементам массива
    // длинна -1, так как ниже i+1 (искуственно отнимаем 1, чтобы пройти весь массив)
    {
        int maxPosition = i;//определяем позицию, на которую смотрим
        //  - рабочая позиция элемента (индекс i)
        // ищем макс элемент
        for (int j = i+1; j < array.Length; j++)// цикл
        // начинаем с i+1
        {
            if(array[j] > array[maxPosition])//смотри текущий элемент и
            {
                 maxPosition = j; // сохраняем макс позицию
            } 
        }
        // меняем значение макс позиции с той, которую нашли
        // замена позиций:
        int temporary = array[i]; // временный элемент, в который кладем
        //рабочая позицию (индекс i)
        array[i] = array[maxPosition]; // кладем в i макс найденный элемент
        array[maxPosition] = temporary; // в макс позицию кладем элемент,
        // который был временный 
    }
}
PrintArray(arr); // обращаемся к методу
SelectionSort(arr); // вызываем метод 
PrintArray(arr);// печатаем упорядоченный массив