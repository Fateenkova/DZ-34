// задача 34. Задайте массив заполненный случайными трехзначными положительными числами.Напишите программу, которая покажет количество четных
// чисел в массиве.
int[] array = new int[9];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(150, 160);
    Console.WriteLine($"{array[i]}");
    if (array[i] % 2 == 0)
    {
       count=count+1;
    }
}

Console.Write(count);