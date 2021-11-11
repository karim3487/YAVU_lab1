using System;

namespace lab1_3
{
    public abstract class Rodent : IRodent
    {
        protected readonly string _detachment;
        private string _kind;
        private string _sex;
        private float _weight;
        private int _age;
        private string _name;
        
        
        
        public string Name { get; set; }
        public string Sex { get; set; }
        public float Weight { get; set; }
        public string Kind { get; set; }
        public int Age { get; set; }
        public string Detachment { get; set; }

        
        //-----------------------------Конструкторы----------------------------
        public Rodent(string detachment) // Конструктор по умолчанию
        {
            Detachment = detachment;
            Kind = null;
            Name = null;
            Age = 0;
            Sex = null;
            Weight = 0;
        }

        public Rodent(Rodent copy, string detachment) // Конструктор копирования
        {
            Kind = copy.Kind;
            Name = copy.Name;
            Age = copy.Age;
            Sex = copy.Sex;
            Weight = copy.Weight;
            Detachment = copy.Detachment;
        }

        public Rodent(int age, float weight, string detachment) // Конструктор с некоторыми параметрами
        {
            Age = age;
            Weight = weight;
            Detachment = detachment;
        }
        
        public Rodent(string kind = null, string name = null, int age = 0, string sex = null,
            float weight = 0,
            string detachment = null) // Конструктор
        {
            Kind = kind;
            Name = name;
            Age = age;
            Sex = sex;
            Weight = weight;
            Detachment = detachment;
            Detachment = detachment;
        }
        
        public virtual void TimeToFeed()
        {
            Console.WriteLine("Время покормить грызуна!");
        }

        public void Scratch()
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
            Name = Console.ReadLine();

            Console.WriteLine("Пол:\n1. Муж.\n2. Жен.");
            string sex;
            do
            {
                sex = Console.ReadLine();
                if (sex == "1")
                    Sex = "Муж";
                else if (sex == "2")
                    Sex = "Жен";
                else
                    Console.WriteLine("Такого варианта нет");
            } while (sex == "1" && sex == "2");

            Console.Write("Возраст: ");
            var inputAge = Console.ReadLine();
            var isAgeConverted = int.TryParse(inputAge, out var age);
            if (isAgeConverted)
                Age = age;
            else
                Console.WriteLine("Некорректный ввод.");

            Console.Write("Вес: ");
            var inputWeight = Console.ReadLine();
            var isWeightConverted = float.TryParse(inputWeight, out var weight);
            if (isWeightConverted)
                Weight = weight;
            else
                Console.WriteLine("Некорректный ввод.");
        }

        public string ShowClassName()
        {
            var className = this.Detachment;
            return className;
        }
    }
}