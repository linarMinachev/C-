# Лекция 3
## Типы методов.

* ### Вид 1 (Ничего не принимает, ничего не возвращает)
```
void Method1()
{
    Console.WriteLine("Автор ....");
}

Method1();  // Вызов метода
```

* ### Вид 2  (Ничего не возвращает, но может принимать аргументы )
```
void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Текст сообщения"); // Вызов метода
```

* ### Вид 2.1

``` 
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method2("Текст", 4);// Вызов метода ( Покажет 4 раза слово текст)
Method2(count: 4, msg: "Новый текст"); // Можно именовать диапозон, тогда можно менять порядок вхожных данных
```

* ### Вид 3 (Возвращает что-то, но ничего не принимает)
```
int Method3()
{
    return DataTime.Now.Year;
}

int year = Method3(); // Вызов метода
Console.WriteLine(year); // Печать результата 
```

* ### Вид 4 (Что-то принимают, что-то возвращают)
```
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // String.Empty - Вместо "". Показывает что пока пустая строка

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "qwerty"); // Вызов метода (10 раз напечатает qwerty)
Console.WriteLine(res); // Печать результата
```

* ### Вид 4.1 (Вариант с циклом for)
```
string Method4(int count, string text)
{
    string result = String.Empty; // String.Empty - Вместо "". Показывает что пока пустая строка
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "qwerty"); // Вызов метода (10 раз напечатает qwerty)
Console.WriteLine(res); // Печать результата
```

* ## ЦИКЛЫ. 
* ### Цикл внутри цикла
```
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i}*{j} = {i * j}");
    }
    Console.WriteLine(); // Переход на новую строку
}
```

>Задача 1. Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить Большими "К",
//  а большие "С" заменить маленькими "с".


```
string text = "-Я думаю, - сказал князь, улыбаясь, что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//            0123456
// s[3] // r ( работа с массивом)

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();
```


> Задача 2. Алгортим сортировки методом выбора.
```
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
```
> Задача 3. Домашняя работа
// Адаптировать код из задачи 2. Сделать сортировку по убыванию
```
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
{
    minPosition = j;
}
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
```

> # Решение задачи 3
```
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

// === Функции ===

// Функция вывода массива в терминал
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// Функция сортировки массива по убыванию
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
```