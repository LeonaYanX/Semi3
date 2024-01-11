// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

// тип массив + [] + название = new + тип + [размер]

// int [] arrray = new int [8]; 

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// string find= "Нет";

// for (int i = 0; i < arrray.Length; i++)
// {
//     arrray[i] = new Random().Next(0,10);
//     Console.Write(arrray[i]+ " ");

//     if(arrray[i]== num)
//     {
//         find = "Да";
        
//     }
// }

// System.Console.WriteLine(find);


// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]

// int sizeArray = 10;

// int [] arrray = new int [sizeArray]; 

// for (int i = 0; i < arrray.Length; i++)
// {
//     arrray[i] = new Random().Next(-10,11);
//     Console.Write(arrray[i]+ " ");
// }

// System.Console.WriteLine();

// for (int i = 0; i < arrray.Length; i++)
// {
//     arrray[i] = -1 * arrray[i];
//     Console.Write(arrray[i]+ " ");
// }

//Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

// int sizeArray = Convert.ToInt32(Console.ReadLine());

// int [] array = new int [sizeArray]; 
// int [] array2 = new int [sizeArray/2]; 

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-10,11);
//     Console.Write(array[i]+ " ");
// }

// System.Console.WriteLine();

// for (int i = 0; i < array2.Length; i++)
// {
//     array2[i] = array[i] * array[array.Length - 1-i];
//     System.Console.Write(array2[i] + "\t");
// }

//task4

// int num = Convert.ToInt32(Console.ReadLine());
// int sizeArray = 3;

// int [] array = new int [sizeArray];  

// for (int i = 0; num > 0; i++,num/=10 )
// {
//     array[i] = num %10;
//     Console.Write(array[i]+ " ");
// }

//в настройках .csproj можно указать версию <TargetFramework>net8.0</TargetFramework>
