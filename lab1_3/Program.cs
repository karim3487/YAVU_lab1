using System;
using System.Collections.Generic;
using lab1_2;

namespace lab1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<INameClass> objectList = new List<INameClass>();
            string selectorMain;
            string selectClassObj;

            do
            {
                Console.WriteLine("\n----------------------------------------------");
                Console.WriteLine("|                   М Е Н Ю                    |");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("|1. Добавить новый объект класса в список.    |");
                Console.WriteLine("|2. Вывести все объекты из списка.            |");
                Console.WriteLine("|3. Выполнить метод для объекта класса.       |");
                Console.WriteLine("|q. Выход из программы.                       |");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Введите пункт меню: ");

                selectorMain = Console.ReadLine();

                switch (selectorMain)
                {
                    case "1":
                    {
                        do
                        {
                            Console.WriteLine("\nВыберите объект класса для добавления в список.");
                            Console.WriteLine("-----------------------------------------------");
                            Console.WriteLine("|1. Капибара (класс Kapibara).                |");
                            Console.WriteLine("|2. Хомяк (класс Hamster).                    |");
                            Console.WriteLine("|3. Бобер (класс Beaver).                     |");
                            Console.WriteLine("|4. Крыска (класс Rat).                       |");
                            Console.WriteLine("|b. Вернуться в меню.                         |");
                            Console.WriteLine("----------------------------------------------");
                            Console.WriteLine("Введите пункт меню: ");

                            selectClassObj = Console.ReadLine();

                            switch (selectClassObj)
                            {
                                case "1":
                                {
                                    Kapibara kapibara = new Kapibara();
                                    kapibara.InputData();
                                    objectList.Add(kapibara);
                                    break;
                                }
                                case "2":
                                    {
                                        Hamster hamster = new Hamster();
                                        hamster.InputData();
                                        objectList.Add(hamster);
                                        break;
                                    }
                                case "3":
                                    {
                                        Beaver beaver = new Beaver();
                                        beaver.InputData();
                                        objectList.Add(beaver);
                                        break;
                                    }
                                case "4":
                                    {
                                        Rat rat = new Rat();
                                        rat.InputData();
                                        objectList.Add(rat);
                                        break;
                                    }
                                case "b":
                                    break;

                                default:
                                    Console.WriteLine("Некорректный ввод.");
                                    break;
                            }
                        } while (selectClassObj != "b");

                    }
                        break;

                    case "2":
                        if (objectList.Count == 0)
                        {
                            Console.WriteLine("\nСписок объектов пуст.");
                        }
                        else
                        {
                            foreach (var thisObject in objectList)
                            {
                                Console.WriteLine("\n" + "Семейство " + thisObject.ShowClassName());
                                Console.WriteLine(thisObject);
                            }
                        }

                        break;

                    case "3":
                        if (objectList.Count == 0)
                        {
                            Console.WriteLine("\nСписок объектов пуст.");
                        }
                        else
                        {
                            string demonstrateMethod = null;
                            do
                            {
                                Console.WriteLine("\nВыберите объект из списка для тестирования методов.");
                                Console.WriteLine("----------------------------------------------");
                                Console.WriteLine("|1. Капибара (класс Kapibara).                |");
                                Console.WriteLine("|2. Хомяк (класс Hamster).                    |");
                                Console.WriteLine("|3. Бобер (класс Beaver).                     |");
                                Console.WriteLine("|4. Крыска (класс Rat).                       |");
                                Console.WriteLine("|b. Вернуться в меню.                         |");
                                Console.WriteLine("----------------------------------------------");
                                Console.WriteLine("Введите пункт меню: ");

                                demonstrateMethod = Console.ReadLine();

                                if (objectList.Count != 0)
                                {
                                    foreach (var currentObj in objectList)
                                    {
                                        if (currentObj.ShowClassName() is "свинковые" && demonstrateMethod is "1")
                                        {
                                            var kapibara =
                                                (Kapibara) currentObj; // приводим объект интерфейса к объекту черного чая
                                            kapibara.StartCap();
                                            kapibara.TimeToFeed();
                                            kapibara.Scratch();
                                        }
                                        else if (currentObj.ShowClassName() is "хомяковые" && demonstrateMethod is "2")
                                        {
                                            var hamster = (Hamster)currentObj; // приводим объект интерфейса к объекту зеленого чая
                                            hamster.StartHam();
                                            hamster.TimeToFeed();
                                            hamster.Scratch();
                                            hamster.HidenNuts();
                                        }
                                        else if (currentObj.ShowClassName() is "бобровые" && demonstrateMethod is "3")
                                        {
                                            var beaver = (Beaver)currentObj; // приводим объект интерфейса к объекту зеленого чая
                                            beaver.StartBeav();
                                            beaver.TimeToFeed();
                                            beaver.Scratch();
                                            beaver.BuildDam();
                                        }
                                        else if (currentObj.ShowClassName() is "мышинные" && demonstrateMethod is "4")
                                        {
                                            var rat = (Rat)currentObj; // приводим объект интерфейса к объекту зеленого чая
                                            rat.StartRat();
                                            rat.TimeToFeed();
                                            rat.Scratch();
                                            rat.EatCheese();
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nСписок пуст.");
                                }

                            } while (demonstrateMethod != "b");
                        }
                        break;
                    case "q":
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод.");
                        break;
                }
            } while (selectorMain != "q");
        }
    }
}