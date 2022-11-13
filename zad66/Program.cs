// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();

Console.Write("Введите M - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N - ");
int n = Convert.ToInt32(Console.ReadLine());
int summ = 0;
if (m > n)
    for (int i = n; i <= m; i++)
        summ += i;
else
    for (int i = m; i <= n; i++)
        summ += i;
Console.WriteLine($"Итоговая сумма = {summ}");
