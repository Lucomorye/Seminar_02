// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
Console.Clear();
int number = new Random().Next(100, 1000);
int firstNumber = number / 100;
int secondNumber = number % 10;
//Console.Write($"{number} -> ");
//Console.WriteLine($"{firstNumber}{secondNumber}");
Console.WriteLine($"{number} -> {firstNumber * 10 + secondNumber}");