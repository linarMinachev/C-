// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X не равен 0 и Y не равен 0, и выдает номер четверти плоскости,
// в которой находится эта точка.

// int x = ReadInt("Введите x: ");
// int y = ReadInt("Введите y: ");

// if (x == 0 || y == 0)
// {
//     Console.WriteLine("Номер четверти определить не удалось");
//     return;
// }

// if(x > 0 && y > 0)
// {
//     Console.WriteLine("Точка в 1 четверти");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("Точка во 2 четверти");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("Точка в 3 четверти");
// }
// else
// {
//     Console.WriteLine("Точка в 4 четверти");
// }


//*** Задача 1. Вариант 1. Задача в группе (Решена самостоятельно дома, так как не был на онлайн семинаре)
// int quarter = ReadInt("Введите номер четверти: ");

// if(quarter < 1 || quarter > 4)
// {
//     Console.WriteLine("Вы вышли за пределы четвертей");
//     return;
// }

// if(quarter == 1)
// {
//     Console.WriteLine("X > 0");
//     Console.WriteLine("y > 0");
// }
// else if(quarter == 2)
// {
//     Console.WriteLine("X < 0");
//     Console.WriteLine("y > 0");
// }
// else if(quarter == 3)
// {
//     Console.WriteLine("X < 0");
//     Console.WriteLine("y < 0");
// }
// else
// {
//     Console.WriteLine("X > 0");
//     Console.WriteLine("y < 0");
// }


//*** Задача 1. Вариант 2. Решение группы
// int quarter = ReadInt("Введите номер четверти: ");
// switch(quarter)
// {
// case 1:
//     Console.WriteLine("X > 0");
//     Console.WriteLine("y > 0");
//     break;
// case 2:
//     Console.WriteLine("X < 0");
//     Console.WriteLine("y > 0");
//     break;
// case 3:
//     Console.WriteLine("X < 0");
//     Console.WriteLine("y < 0");
//     break;
// case 4:
//     Console.WriteLine("X > 0");
//     Console.WriteLine("y < 0");
//     break;
//  default:
//     Console.WriteLine("Вы вышли за пределы четвертей");
//     break;
// }

//*** Задача 2. Решение группы Нахождение длинны отрезка в 2D пространстве
// int x1 = ReadInt("Введите координату X первой точки: ");
// int y1 = ReadInt("Введите координату Y первой точки: ");
// int x2 = ReadInt("Введите координату X второй точки: ");
// int y2 = ReadInt("Введите координату Y второй точки: ");

// double length = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

// Console.WriteLine($"Длинна отрезка {length}");


//*** Задача 4. Вариант 1. Мое Решение
// Напишите программу, которая принимает на вход число (N)
// и выдает таблицу кадратов чисел от 1 до N
// 5 -> 1,4,9,16,25
// 2 -> 1.4

int numberN = ReadInt("Введите число: ");

for (int i = 1; i <= numberN; i++)
{ 
    Console.Write($"{i*i} ");
}

// Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}