using System;

namespace KapibaraClass
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string select = null;
            var kap = new Kapibara();
            Console.WriteLine("Демонстарция класса 'Kapibara'.");
            do
            {
                Console.WriteLine("\n------------------------------------------------");
                Console.WriteLine("|                     М Е Н Ю                  |");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("| 1. Задать параметры объекта.                 |");
                Console.WriteLine("| 2. Вывести свойства объекта.                 |");
                Console.WriteLine("| 3. К какому семейсвту относится.             |");
                Console.WriteLine("| 4. Начать капибариться.                      |");
                Console.WriteLine("| 5. Поплавать.                                |");
                Console.WriteLine("| 6. Почесать Капибару.                        |");
                Console.WriteLine("| q. Выход из программы.                       |");
                Console.WriteLine("------------------------------------------------");
                Console.Write("Введите пункт меню: ");

                select = Console.ReadLine();
                switch (select)
                {
                    case "1":
                        Console.WriteLine(
                            "\nДалее введите данные о капибаре.\n------------------------------------------------");
                        Console.WriteLine("Имя: ");
                        kap.Name = Console.ReadLine();

                        Console.WriteLine("Пол:\n1. Муж.\n2. Жен.");
                        var sex = Console.ReadLine();
                        if (sex == "1")
                            kap.Sex = "Муж";
                        else if (sex == "2")
                            kap.Sex = "Жен";
                        else
                            Console.WriteLine("Такого варианта нет");

                        Console.Write("Возраст: ");
                        var inputAge = Console.ReadLine();
                        var isAgeConverted = int.TryParse(inputAge, out var age);
                        if (isAgeConverted)
                            kap.Age = age;
                        else
                            Console.WriteLine("Некорректный ввод.");

                        Console.Write("Вес: ");
                        var inputWeight = Console.ReadLine();
                        var isWeightConverted = int.TryParse(inputWeight, out var weight);
                        if (isWeightConverted)
                            kap.Weight = weight;
                        else
                            Console.WriteLine("Некорректный ввод.");
                        Console.WriteLine("------------------------------------------------");
                        break;
                    case "2":
                        Console.WriteLine(kap);
                        break;
                    case "3":
                        Console.WriteLine("Капибара относится к семейству " + kap.GetAdvice());
                        break;
                    case "4":
                        kap.StartKap();
                        break;
                    case "5":
                        kap.Swiming();
                        break;
                    case "6":
                        kap.Scratch();
                        break;
                }
            } while (select != "q");
        }
    }
}