// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine($"Введите трехзначное число, и я выведу 3 цифру этого числа.Зачем? Да просто! ");
Console.WriteLine($"Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());


int SecondNumber(int num)
{
    int number3 = num%10;
    return number3;
}
if (99 < a && a < 1000) {
int result = SecondNumber(a);
Console.Write($"{a} -> {result}");
}
else Console.Write($"{a}-> тут третьей цифры,нет!");