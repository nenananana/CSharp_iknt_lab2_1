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
            bool firstLogicalField = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Введите логическое значение второго поля (true/false): ");
            bool secondLogicalField = Convert.ToBoolean(Console.ReadLine());

            Console.Clear();

            // Тестирование базового класса
            TwoLogicalField baseObject = new TwoLogicalField(firstLogicalField, secondLogicalField);

            Console.WriteLine(baseObject.ToString());
            Console.WriteLine($"Дизъюнкция (логическое ИЛИ) = {baseObject.Disjunction()}");

            TwoLogicalField copiedBaseObject = new TwoLogicalField(baseObject);

            Console.WriteLine($"Конструктор копированя: {copiedBaseObject.ToString()}");

            // Тестирование дочернего класса
            int positionCursorLeft = Console.CursorLeft;
            int positionCursorTop = Console.CursorTop;

            Console.WriteLine("\nВводится имя системы и проверяется работает ли она.");
            Console.WriteLine("Если хотя бы один из показателей работает, то система работает.");
            Console.WriteLine("Введите название системы: ");

            string nameSystem = Console.ReadLine();

            Console.SetCursorPosition(positionCursorLeft, positionCursorTop);
            Console.Write(new string(' ', Console.WindowWidth * 4)); // Очищаем 3 строки


            SystemStatus systemState = new SystemStatus(nameSystem, firstLogicalField, secondLogicalField);

            Console.WriteLine(systemState.ToString());
            Console.WriteLine(systemState.GetSystemStatus());
            Console.WriteLine($"Выполняется {Convert.ToString(systemState.GetNumberActivField(firstLogicalField, secondLogicalField))} процессов");
        }
        catch
        {
            Console.WriteLine("Некорректный ввод");
        }
    }
}
