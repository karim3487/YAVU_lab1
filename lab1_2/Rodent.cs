using System;

namespace lab1_2
{
    public abstract class Rodent
    {
        protected readonly string _detachment;
        protected int _age;
        protected string _kind;
        protected string _name;
        protected string _sex;
        protected float _weight;

        //-----------------------------Конструкторы----------------------------
        public Rodent(string detachment) // Конструктор по умолчанию
        {
            Detachment = detachment;
            _kind = null;
            _name = null;
            _age = 0;
            _sex = null;
            _weight = 0;
            _detachment = null;
        }

        public Rodent(Rodent copy, string detachment) // Конструктор копирования
        {
            Detachment = detachment;
            _kind = copy._kind;
            _name = copy._name;
            _age = copy._age;
            _sex = copy._sex;
            _weight = copy._weight;
            _detachment = copy._detachment;
        }

        public Rodent(int age, float weight, string detachment) // Конструктор с некоторыми параметрами
        {
            _age = age;
            _weight = weight;
            Detachment = detachment;
        }
        
        public Rodent(string kind = null, string name = null, int age = 0, string sex = null,
            float weight = 0,
            string detachment = null) // Конструктор
        {
            _kind = kind;
            _name = name;
            _age = age;
            _sex = sex;
            _weight = weight;
            Detachment = detachment;
            _detachment = detachment;
        }

        // --------------------Геттеры и сеттеры--------------------------
        public int Age
        {
            get => _age;
            set
            {
                _age = value;
                if (_age < 0) _age = 0; // возраст не может быть меньше 0
            }
        }

        public float Weight
        {
            get => _weight;
            set
            {
                _weight = value;
                if (_weight < 1) _weight = 0; // вес не может быть отрицательным 
            }
        }

        public string Kind { get; set; }
        public string Sex { get; set; }
        
        public string Name { get; set; }
        public string Detachment { get; set; }

        //-----------------------------КОНЕЦ Конструкторы----------------------------
        //  ------------------------Методы класса------------------------
        public override string ToString() // Перегрузка метода ToString;
        {
            if (Sex == "Жен")
                return string.Format(
                    "{4} {0} приветствует!\nНаша {0} {1}, ее вес составляет {2}кг\nЕй {3}\n", _name,
                    _weight > 45 ? "упитанная" : "голодает", _weight, _age, _kind);
            return string.Format(
                "{4} {0} приветствует!\nНаш {0} {1}, его вес составляет {2}кг\nЕму {3}\n", _name,
                _weight > 45 ? "упитанный" : "голодает", _weight, _age, _kind);
        }

        public virtual void TimeToFeed() // Вируальный метод
        {
            Console.WriteLine("Время покормить грызуна!");
        }

        public virtual void Scratch()
        {
            Console.WriteLine("Привет кожанный, есть минутка??? \n1. да\n2. нет");
            var choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine(
                    "Почеши мне пожалуйста спинку, а то я своими лапками не могу достать до нее :( :( :( \n1. Ок\n2. Обидеть грызуна");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                    Console.WriteLine(
                        "Грызун благодарен тебе, а грызун у нас гений программирования. И теперь, когда тебе " +
                        "понадобится помощь с курсовой грызун тебе поможет)))");
                else if (choice == 2)
                    Console.WriteLine(
                        "Грызун обиделся и сделает все возмоное чтобы тебя завалили на ЭКЗАМЕНЕ\nЫХХЫХЫХЫХЫ (Злой смехъ)");
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

        public virtual void InputData()
        {
            Console.WriteLine("\nДалее введите данные о грызуне.\n------------------------------------------------");
            Console.WriteLine("Имя: ");
            _name = Console.ReadLine();

            Console.WriteLine("Пол:\n1. Муж.\n2. Жен.");
            string sex;
            do
            {
                sex = Console.ReadLine();
                if (sex == "1")
                    _sex = "Муж";
                else if (sex == "2")
                    _sex = "Жен";
                else
                    Console.WriteLine("Такого варианта нет");
            } while (sex == "1" && sex == "2");

            Console.Write("Возраст: ");
            var inputAge = Console.ReadLine();
            var isAgeConverted = int.TryParse(inputAge, out var age);
            if (isAgeConverted)
                _age = age;
            else
                Console.WriteLine("Некорректный ввод.");

            Console.Write("Вес: ");
            var inputWeight = Console.ReadLine();
            var isWeightConverted = float.TryParse(inputWeight, out var weight);
            if (isWeightConverted)
                _weight = weight;
            else
                Console.WriteLine("Некорректный ввод.");
        }

        public static void ShowClassName()
        {
            Console.WriteLine("Имя класса: 'Rodent'.");
        }
        //  ------------------------КОНЕЦ Методы класса------------------------
    }
}