using System;

namespace lab1_2

{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string selectorMain;
            string selectorClass;
            var kapibara = new Kapibara();
            var hamster = new Hamster();
            var beaver = new Beaver();
            var rat = new Rat();

            do
            {
                Console.WriteLine("\n------------------------------------------------");
                Console.WriteLine("|                     Меню                     |");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("|1. Капибара (класс Kapibara).                |");
                Console.WriteLine("|2. Хомяк (класс Hamster).                    |");
                Console.WriteLine("|3. Бобер (класс Beaver).                     |");
                Console.WriteLine("|4. Крыска (класс Rat).                       |");
                Console.WriteLine("|q. Выход из программы.                       |");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Введите пункт меню: ");

                selectorMain = Console.ReadLine();

                switch (selectorMain)
                {
                    case "1":
                        do
                        {
                            Console.WriteLine("\n-----------------------------------------------");
                            Console.WriteLine("|                  Капибара                   |");
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine("|1. Задать параметры объекта.                 |");
                            Console.WriteLine("|2. Вывести свойства объекта.                 |");
                            Console.WriteLine("|3. Вывести текущее имя класса.               |");
                            Console.WriteLine("|4. Почесать капибару.                        |");
                            Console.WriteLine("|5. Начать капибариться.                      |");
                            Console.WriteLine("|6. TimeToFeed.                               |");
                            Console.WriteLine("|7. К какому семейству относится.             |");
                            Console.WriteLine("|b. Вернуться в главное меню.                 |");
                            Console.WriteLine("-----------------------------------------------");
                            Console.WriteLine("Введите пункт меню: ");

                            selectorClass = Console.ReadLine();

                            switch (selectorClass)
                            {
                                case "1":
                                    kapibara.InputData();
                                    break;
                                
                                case "2":
                                    Console.WriteLine(kapibara);
                                    break;
                                
                                case "3":
                                    Kapibara.ShowClassName();
                                    break;
                                
                                case "4":
                                    kapibara.Scratch();
                                    break;
                                
                                case "5":
                                    kapibara.StartCap();
                                    break;
                                
                                case "6":
                                    kapibara.TimeToFeed();
                                    break;
                                
                                case "7":
                                    var kapibaraDetachment = kapibara.Detachment;
                                    Console.WriteLine("Капибара относится к семейству " + kapibaraDetachment);
                                    break;
                                
                                default:
                                    Console.WriteLine("Нет такого варианта");
                                    break;
                            }
                            
                        } while (selectorClass != "b");
                        break;
                    case "2":
                        do
                        {
                            Console.WriteLine("\n-----------------------------------------------");
                            Console.WriteLine("|                    Хомяк                    |");
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine("|1. Задать параметры объекта.                 |");
                            Console.WriteLine("|2. Вывести свойства объекта.                 |");
                            Console.WriteLine("|3. Вывести текущее имя класса.               |");
                            Console.WriteLine("|4. Почесать хомяка.                          |");
                            Console.WriteLine("|5. Спрятать орешки.                          |");
                            Console.WriteLine("|6. TimeToFeed.                               |");
                            Console.WriteLine("|7. К какому семейству относится.             |");
                            Console.WriteLine("|b. Вернуться в главное меню.                 |");
                            Console.WriteLine("-----------------------------------------------");
                            Console.WriteLine("Введите пункт меню: ");

                            selectorClass = Console.ReadLine();

                            switch (selectorClass)
                            {
                                case "1":
                                    hamster.InputData();
                                    break;
                                
                                case "2":
                                    Console.WriteLine(hamster);
                                    break;
                                
                                case "3":
                                    Hamster.ShowClassName();
                                    break;
                                
                                case "4":
                                    hamster.Scratch();
                                    break;
                                
                                case "5":
                                    hamster.HidenNuts();
                                    break;
                                
                                case "6":
                                    hamster.TimeToFeed();
                                    break;
                                
                                case "7":
                                    var hamsterDetachment = hamster.Detachment;
                                    Console.WriteLine("Хомяк относится к семейству " + hamsterDetachment);
                                    break;
                                
                                default:
                                    Console.WriteLine("Нет такого варианта");
                                    break;
                            }
                            
                        } while (selectorClass != "b");
                        break;
                    
                    case "3":
                        do
                        {
                            Console.WriteLine("\n-----------------------------------------------");
                            Console.WriteLine("|                    Бобер                    |");
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine("|1. Задать параметры объекта.                 |");
                            Console.WriteLine("|2. Вывести свойства объекта.                 |");
                            Console.WriteLine("|3. Вывести текущее имя класса.               |");
                            Console.WriteLine("|4. Почесать бобра.                           |");
                            Console.WriteLine("|5. Построить платину.                        |");
                            Console.WriteLine("|6. TimeToFeed.                               |");
                            Console.WriteLine("|7. К какому семейству относится.             |");
                            Console.WriteLine("|b. Вернуться в главное меню.                 |");
                            Console.WriteLine("-----------------------------------------------");
                            Console.WriteLine("Введите пункт меню: ");

                            selectorClass = Console.ReadLine();

                            switch (selectorClass)
                            {
                                case "1":
                                    beaver.InputData();
                                    break;
                                
                                case "2":
                                    Console.WriteLine(beaver);
                                    break;
                                
                                case "3":
                                    Beaver.ShowClassName();
                                    break;
                                
                                case "4":
                                    beaver.Scratch();
                                    break;
                                
                                case "5":
                                    beaver.BuildDam();
                                    break;
                                
                                case "6":
                                    beaver.TimeToFeed();
                                    break;
                                
                                case "7":
                                    var hamsterDetachment = beaver.Detachment;
                                    Console.WriteLine("Бобер относится к семейству " + hamsterDetachment);
                                    break;
                                
                                default:
                                    Console.WriteLine("Нет такого варианта");
                                    break;
                            }
                        } while (selectorClass != "b");
                        break;
                    
                    case "4":
                        do
                        {
                            Console.WriteLine("\n-----------------------------------------------");
                            Console.WriteLine("|                    Крыса                    |");
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine("|1. Задать параметры объекта.                 |");
                            Console.WriteLine("|2. Вывести свойства объекта.                 |");
                            Console.WriteLine("|3. Вывести текущее имя класса.               |");
                            Console.WriteLine("|4. Почесать крыску.                           |");
                            Console.WriteLine("|5. Покушать сыр.                             |");
                            Console.WriteLine("|6. TimeToFeed.                               |");
                            Console.WriteLine("|7. К какому семейству относится.             |");
                            Console.WriteLine("|b. Вернуться в главное меню.                 |");
                            Console.WriteLine("-----------------------------------------------");
                            Console.WriteLine("Введите пункт меню: ");

                            selectorClass = Console.ReadLine();

                            switch (selectorClass)
                            {
                                case "1":
                                    rat.InputData();
                                    break;
                                
                                case "2":
                                    Console.WriteLine(rat);
                                    break;
                                
                                case "3":
                                    Rat.ShowClassName();
                                    break;
                                
                                case "4":
                                    rat.Scratch();
                                    break;
                                
                                case "5":
                                    rat.EatCheese();
                                    break;
                                
                                case "6":
                                    rat.TimeToFeed();
                                    break;
                                
                                case "7":
                                    var ratDetachment = rat.Detachment;
                                    Console.WriteLine("Крыса относится к семейству " + ratDetachment);
                                    break;
                                
                                default:
                                    Console.WriteLine("Нет такого варианта");
                                    break;
                            }
                        } while (selectorClass != "b");
                        break;
                    case "b":
                        Console.WriteLine();
                        break;
                }
            } while (selectorMain != "q");
        }
    }
}