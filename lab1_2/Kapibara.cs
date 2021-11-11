using System;

namespace lab1_2

{
    public class Kapibara : Rodent
    {
        private int _height; // Рост

        // Конструктор
        public Kapibara(string name = null, int height = 0, string sex = null, int age = 0, string kind = "Капибара",
            float weight = 0, string detachment = "свинковые") : base(kind, name, age, sex, weight, detachment)
        {
            _height = height;
        }

        
        public void StartCap() // метод класса
        {
            Console.WriteLine("Начинаем КАПИБАРТЬСЯ :3");
        }

        public override void TimeToFeed() // Вируальный метод
        {
            Console.WriteLine("Время покормить капибару!");
        }

        public new static void ShowClassName()
        {
            Console.WriteLine("Имя класса: 'Kapibara'.");
        }

        public override void InputData()
        {
            base.InputData();
            Console.Write("Рост в холке: ");
            var inputHeight = Console.ReadLine();
            var isHeightConverted = int.TryParse(inputHeight, out var height);
            if (isHeightConverted)
                _height = height;
            else
                Console.WriteLine("Некорректный ввод.");
            Console.WriteLine("------------------------------------------------");
        }
        
        public override string ToString() // Перегрузка метода ToString;
        {
            if (Sex == "Жен")
                return string.Format(
                    "{4} {0} приветствует!\nНаша девочка {0} {1}, ее вес составляет {2}кг\nЕй {3}, а рост в холке составляет {5} см\n", _name,
                    _weight > 45 ? "упитанная" : "голодает", _weight, _age, _kind, _height);
            return string.Format(
                "{4} {0} приветствует!\nНаш мальчик {0} {1}, его вес составляет {2}кг\nЕму {3}, а рост в холке составляет {5} см\n", _name,
                _weight > 45 ? "упитанный" : "голодает", _weight, _age, _kind, _height);
        }
    }
}