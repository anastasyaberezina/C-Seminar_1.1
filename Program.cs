// Напишите программу, которая на вход принимает число и выдает его квадрат (число, умноженное на само себя).

Console.WriteLine("Введи число: ");
int number = int.Parse(Console.ReadLine());

//Возведение в квадрат математическим методом.

int sqr = number * number;

Console.WriteLine($"Квадрат числа {number} равен = {sqr}");


//Метод с использованием библиотеки.

int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Вложенная библиотека: Квадрат числа {number} равен = {sqr1}");
