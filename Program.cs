using System;

class Program
{
    static void Main()
    {
        // ===== 1. Проверка GenericContainer =====
        Console.WriteLine("\n----------------");
        var floatContainer = new GenericContainer<float>();
        floatContainer.SetValue(3.14f); //записываем значения
        Console.WriteLine(floatContainer.GetValue()); //выводим

        var boolContainer = new GenericContainer<bool>();
        boolContainer.SetValue(true);
        Console.WriteLine(boolContainer.GetValue());

        // ===== 2. Проверка Swap =====
        Console.WriteLine("\n----------------");
        int a = 5, b = 10;
        Utils.Swap(ref a, ref b); //меняем местами
        Console.WriteLine($"{a}, {b}");

        string s1 = "Hello", s2 = "World";
        Utils.Swap(ref s1, ref s2);
        Console.WriteLine($"{s1}, {s2}");

        // ===== 3. Проверка PrintCollection =====
        Console.WriteLine("\n----------------");
        Utils.PrintCollection(new int[] { 1, 2, 3 });
        Utils.PrintCollection(new string[] { "A", "B", "C" });

        // ===== 4. Проверка Comparer =====
        Console.WriteLine("\n----------------");
        Console.WriteLine(Comparer<int>.Max(5, 10));
        Console.WriteLine(Comparer<int>.Min(5, 10));

        Console.WriteLine(Comparer<double>.Max(2.5, 1.1));
        Console.WriteLine(Comparer<string>.Max("A", "B"));

    }
}