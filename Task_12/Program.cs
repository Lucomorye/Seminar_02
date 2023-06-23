// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе 
// число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления
Console.Clear();
Console.WriteLine("Введите первое число");
int firstNumber = int.Parse (Console.ReadLine()!);

Console.WriteLine("Введите второе число");
int secondNumber = int.Parse (Console.ReadLine()!);

double rem = firstNumber % secondNumber;

if (firstNumber % secondNumber == 0)
{
  Console.WriteLine($"{firstNumber},{secondNumber} -> кратно");
}
else
{
  Console.WriteLine($"{firstNumber},{secondNumber} -> не кратно, остаток {rem}");
}

