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

int sizeArray = 10;

int [] arrray = new int [sizeArray]; 

for (int i = 0; i < arrray.Length; i++)
{
    arrray[i] = new Random().Next(-10,11);
    Console.Write(arrray[i]+ " ");
}

System.Console.WriteLine();

for (int i = 0; i < arrray.Length; i++)
{
    arrray[i] = -1 * arrray[i];
    Console.Write(arrray[i]+ " ");
}