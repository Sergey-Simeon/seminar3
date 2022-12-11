// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Реализовать через функции.
int Phrase(string message)

{
    System.Console.Write($"{message} > ");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
int n = Phrase("Введите число: ");

 int getSum(int n)
    {
        int sum = 0;
 
        while (n != 0) {
            sum = sum + n % 10;
            n = n / 10;
        }
 
        return sum;
    }
     Console.Write($"Сумма цифр = {getSum(n)}");