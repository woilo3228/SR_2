// Дана последовательность дейтвительных чисел. Указать те её элементы, которые принадлежат отрезку [c,d].
class Program
{
    static void Main()
    {
        // Выбираем размер массива
        Console.WriteLine("Введите размер массива:");
        int size = int.Parse(Console.ReadLine());
        double[] array = new double[size];

        // Заполняем массив
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < size; i++)
        {
            array[i] = double.Parse(Console.ReadLine());
        }

        // Выбираем промежуток
        Console.WriteLine("Введите число c:");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите число d:");
        double d = double.Parse(Console.ReadLine());

        Console.WriteLine($"Действительные числа, принадлежащие отрезку [{c}; {d}]:");
        foreach (double number in array)
        {
            if (number >= c && number <= d)
            {
                Console.WriteLine(number);
            }
        }
    }
}
