/*
 * Задача 43
 * Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
 */

double Input(string text)
{
    while (true)
    {
        try
        {
            Console.Write(text);
            return double.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Введеное не число, попробуте еще раз!");
        }
    }
}


double b1 = Input("Введите значение b1: ");
double k1 = Input("Введите значение k1: ");
double b2 = Input("Введите значение b2: ");
double k2 = Input("Введите значение k2: ");
if ((k1 == k2) && (b1 == b2))
    Console.WriteLine("Прямые одинаковые!");
else if (k1 == k2)
    Console.WriteLine("Прямые параллельны!");
else
{
    double x = Math.Round(-(b1 - b2) / (k1 - k2), 2);
    double y = Math.Round(k1 * x + b1, 2);
    Console.WriteLine($"Точка пересечения двух прямых: [x:{x}; y:{y}]");
}