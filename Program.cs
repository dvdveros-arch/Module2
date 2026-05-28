using System;

class Program
{
    static void Main()
    {
        // ===== 1. Проверка GenericContainer =====
        var floatContainer = new GenericContainer<float>();
        floatContainer.SetValue(3.14f); //записываем значения
        Console.WriteLine(floatContainer.GetValue()); //выводим

        var boolContainer = new GenericContainer<bool>();
        boolContainer.SetValue(true);
        Console.WriteLine(boolContainer.GetValue());
    }
}