
using L2_1;
using System;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите логическое значение первого поля (true/false): ");
            bool field1 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Введите логическое значение второго поля (true/false): ");
            bool field2 = Convert.ToBoolean(Console.ReadLine());

            // Тестирование базового класса
            TwoLogicalField baseObj = new TwoLogicalField(field1, field2);
            Console.WriteLine(baseObj.ToString());
            Console.WriteLine($"Дизъюнкция (логическое ИЛИ) = {baseObj.Disjunction()}");
            // Тестирование конструктора копирования базового класса
            TwoLogicalField copiedBaseObj = new TwoLogicalField(baseObj);
            Console.WriteLine($"Конструктор копированя:  {copiedBaseObj.ToString()}");

            // --------------------------------------------------------------------------- //

            // Тестирование дочернего класса
            Console.WriteLine("\nВводится имя сисетмы и проверяется работает ли она. \nЕсли хотя бы один из показателей работает, то система работает.");
            Console.WriteLine("Введите название системы: ");
            string name = Convert.ToString(Console.ReadLine());
            SystemStatus systemState = new SystemStatus(name, field1, field2);
            Console.WriteLine(systemState.ToString());
            Console.WriteLine(systemState.GetSystemStatus());

            Console.WriteLine($"Выполняется {Convert.ToString(systemState.GetNumber(field1, field2))} процессов");
        }
        catch
        {
            Console.WriteLine("Некорректный ввод");
        }
    }
}
