/*Вариант 5
Грызуны.
Класс для первой части - капибара
Варианты свойств: вес, пол, возраст, имя
Варианты методов: капибариться, плавать, чесать, получить совет от
капибары (статический)*/

using System;

namespace KapibaraClass
{
    public class Kapibara
    {
        private readonly string _rodentFamily;
        private int _age;
        private readonly string _name;
        private readonly string _sex;
        private float _weight;

        //-----------------------------Конструкторы----------------------------
        public Kapibara() // Конструктор по умолчанию
        {
            _name = "Леша";
            _age = 15;
            _sex = "Муж";
            _weight = 35;
            _rodentFamily = "Свинковые";
        }

        public Kapibara(Kapibara copy) // Конструктор копирования
        {
            _name = copy._name;
            _age = copy._age;
            _sex = copy._sex;
            _weight = copy._weight;
            _rodentFamily = copy._rodentFamily;
        }

        public Kapibara(int age, float weight) // Конструктор с некоторыми параметрами
        {
            _age = age;
            _weight = weight;
        }

        public Kapibara(string name = "Оксана", int age = 10, string sex = "Жен", float weight = 46,
            string rodentFamily = "Свинковые") // Конструктор
        {
            _name = name;
            _age = age;
            _sex = sex;
            _weight = weight;
            _rodentFamily = rodentFamily;
        }

        //-----------------------------КОНЕЦ Конструкторы----------------------------
        // --------------------Геттеры и сеттеры--------------------------
        public int Age
        {
            get => _age;
            set
            {
                _age = value;
                if (_age < 0) _age = 0;
            }
        }

        public float Weight
        {
            get => _weight;
            set
            {
                _weight = value;
                if (_weight < 0) _weight = 0;
            }
        }

        public string Name { get; set; }

        public string Sex { get; set; }

        // --------------------КОНЕЦ Геттеры и сеттеры--------------------------
        //  ------------------------Методы класса------------------------
        public static void GetAdvice()
        {
            Console.WriteLine(
                "Не откладывай лабы на последний момент!");
        }

        public void StartKap()
        {
            Console.WriteLine("Начинаем КАПИБАРТЬСЯ :3");
        }

        public void Swimming()
        {
            Console.WriteLine("По-о-о-о-оплыли))");
        }

        public string GetRodentFamily()
        {
            return _rodentFamily;
        }

        public void Scratch()
        {
            Console.WriteLine("Привет кожанный, есть минутка??? \n1. да\n2. нет");
            var choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine(
                    "Почеши мне пожалуйста спинку, а то я своими лапками не могу достать до нее :( :( :( \n1. Ок\n2. Обидеть капибару");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                    Console.WriteLine(
                        "Капибара {0} благодарен тебе, а {0} у нас гений программирования.\nИ теперь, когда тебе " +
                        "понадобится помощь с курсовой капибара {0} тебе поможет)))", Name);
                else if (choice == 2)
                    Console.WriteLine(
                        "Капибара {0} обиделся и сделает все возмоное чтобы тебя завалили на ЭКЗАМЕНЕ\nЫХХЫХЫХЫХЫ (Злой смехъ)",
                        Name);
                else
                    Console.WriteLine("Такого варианта нет");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Эххх..... Ну ладно(((");
            }
            else
            {
                Console.WriteLine("Такого варианта нет");
            }
        }

        public override string ToString()
        {
            if (Sex == "Жен")
            {
                return string.Format(
                    "  Капибара {0} приветствует!\nНаша {0} {1}, ее вес составляет {2}кг\nЕй {3}\n", Name,
                    Weight > 45 ? "упитанная" : "голодает", Weight, Age);
            }
            else
            {
                return string.Format(
                    "  Капибара {0} приветствует!\nНаш {0} {1}, его вес составляет {2}кг\nЕму {3}\n", Name,
                    Weight > 45 ? "упитанный" : "голодает", Weight, Age);
            }
        }
        //  ------------------------КОНЕЦ Методы класса------------------------
    }
}