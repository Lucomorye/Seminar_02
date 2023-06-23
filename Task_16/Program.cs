//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом 
//другого.
Console.Clear();
Console.WriteLine("Введите первое число");
int firstNumber = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int secondNumber = int.Parse(Console.ReadLine()!);

if ( firstNumber * firstNumber == secondNumber || secondNumber * secondNumber == firstNumber)
{
  Console.WriteLine($"{firstNumber},{secondNumber} -> да");
}
else
{
  Console.WriteLine($"{firstNumber},{secondNumber} -> нет");
}