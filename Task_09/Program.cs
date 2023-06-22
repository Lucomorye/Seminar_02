// Напишите программу которая выводит случайное число из отрезка 10 - 99, и показывает наибольшую цифру числа.
Console.Clear();
int number = new Random().Next(10,100);
int firstNumber = number / 10;
int secondNumber = number % 10;

if(firstNumber > secondNumber)
{
  Console.WriteLine($"{number}  ->  {firstNumber}");
}
else
{
  Console.WriteLine($"{number} -> {secondNumber}");
}
