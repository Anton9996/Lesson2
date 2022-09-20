// Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет, является ли это выходным
Console.WriteLine($"Введите число, от одного до семи, я скажу, выходной это в разрезе недели или нет");
Console.WriteLine($"Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int Weekend(int num)
{
 return num  == 6 || num  == 7 ? 1 : 0;
}
if (0 < a && a < 8) {
int result = Weekend(a);
string res = result == 1 ? "выходной" : "будни";
Console.Write($"{a} -> {res}");;
}
else Console.Write($"{a}-> в недели 7 дней");