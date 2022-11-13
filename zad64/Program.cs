// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();

Console.Write("Введите N - ");
int n = Convert.ToInt32(Console.ReadLine());

string vyvod(int n)
{
    return (n == 1 ? "1" : vyvod(n - 1) + n);
}
Console.WriteLine(vyvod(n));
