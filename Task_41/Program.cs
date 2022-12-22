/*
 * Задача 41
 * Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
 */

int Input(string text)
{
    while (true)
    {
        try
        {
            Console.Write(text);
            return int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Введеное не число, попробуте еще раз!");
        }
    }
}

while (true)
{
    int m = Input("Какое количество чисел хотите внести: ");
    if (m > 0)
    {
        int[] numbers = new int[m];
        int count = 0;
        while (--m >= 0)
        {
            numbers[m] = Input($"Введите число {numbers.Length - m}: ");
            if (numbers[m] > 0) count++;
        }
        Console.WriteLine($"Чисел больше 0: {count}");
        break;
    } else {
        Console.WriteLine("Количество чисел должно быть больше 0");
    }
}