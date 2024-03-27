// Дана последовательность дейтвительных чисел. Указать те её элементы, которые принадлежат отрезку [c,d].
class Program
{
    static void Main()
    {
        // Задаём последовательность действительных чисел
        double[] array = { -3.5, -2.3, -2.1, -1.9, -1.1, -0.2, 0.5, 2.5, 2.8, 3.7, 5.6, 6.5, 7.8 };

        // Задаём границы отрезка
        Console.WriteLine("Введите число c");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите число c");
        double d = double.Parse(Console.ReadLine());

        Console.WriteLine($"Действительные числа, принадлежащие отрезку [{c}, {d}]:");

        // Производим выборку
        foreach (double number in array)
        {
            if (number >= c && number <= d)
            {
                // Выводим действительные числа, удовлетворяющие условию
                Console.WriteLine(number);
            }
        }
    }
}