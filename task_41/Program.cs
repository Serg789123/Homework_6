// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
// ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество элементов массива:\t ");
int elementsCount = int.Parse(Console.ReadLine());
int[] myArray = new int[elementsCount];
int count = 0;
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"Введите положительное или отрицательное число под индексом: {i}:\t ");
    myArray[i] = int.Parse(Console.ReadLine());
    if (myArray[i] > 0) count++;
}
Console.WriteLine($"Количество положительных чисел в массиве = {count}");
