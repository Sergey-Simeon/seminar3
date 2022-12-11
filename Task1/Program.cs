// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Реализовать через функции.
int Phrase(string message)

{
    System.Console.Write($"{message} > ");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
int a = Phrase ("Введите число А ");
int b = Phrase ("Введите число B ");
int result = a;

if (a > 0 && b > 0)
{

for (int n = 1; n < b; n++)
{
    result = result * a;
}
Console.Write($"Результат возведения в степень = {result}");
}
else
{
    Console.Write("Вы ввели ненатуральное число");
}