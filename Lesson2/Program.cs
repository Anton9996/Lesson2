// Напишите программу, которая принимаеи на вход трехзначное число и на выходе показывает вторую цифру этого числа.


Console.WriteLine($"Введите трехзначное число, и я выведу 2 цифру этого числа.Зачем? Да просто! ");
Console.WriteLine($"Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());


int SecondNumber(int num)
{
    int number2 = ((num/10)%10);
    return number2;
}
if (99 < a && a < 1000) {
int result = SecondNumber(a);
Console.Write($"{a} -> {result}");
}
else Console.Write($"Это не трехзначное число");