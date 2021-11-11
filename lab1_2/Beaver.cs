using System;

namespace lab1_2
{
    public class Beaver : Rodent
    {
        private int _tailLenght;
        
        public int TailLenght
        {
            get => _tailLenght; // длина хваста
            set
            {
                _tailLenght = value;
                if (_tailLenght < 0) _tailLenght = 0; // длина хваста не может быть меньше 0
            }
        }
        
        public Beaver(string name = null, int tailLenght = 0, string sex = null, int age = 0, string kind = "Бобер",
            float weight = 0, string detachment = "бобровые") : base(kind, name, age, sex, weight, detachment)
        {
            _tailLenght = tailLenght;
        }

        
        public void StartBeav() // метод класса
        {
            Console.WriteLine("Начинаем БОБРИТЬСЯ :3");
        }

        public override void TimeToFeed() // Вируальный метод
        {
            Console.WriteLine("Время покормить бобра!");
        }

        public new static void ShowClassName()
        {
            Console.WriteLine("Имя класса: 'Beaver'.");
        }
        
        public override void InputData()
        {
            base.InputData();
            Console.Write("Длина хвостика (в см): ");
            var inputTailLenght = Console.ReadLine();
            var isTailLenghtConverted = int.TryParse(inputTailLenght, out var tailLenght);
            if (isTailLenghtConverted)
                _tailLenght = tailLenght;
            else
                Console.WriteLine("Некорректный ввод.");
            Console.WriteLine("------------------------------------------------");
        }
        
        public override string ToString() // Перегрузка метода ToString;
        {
            if (Sex == "Жен")
                return string.Format(
                    "{4} {0} приветствует!\nНаша девочка {0} {1}, ее вес составляет {2}кг\nЕе возраст {3}, а длина хвостика {5} см\n", _name,
                    _weight > 45 ? "упитанная" : "голодает", _weight, _age, _kind, _tailLenght);
            return string.Format(
                "{4} {0} приветствует!\nНаш мальчик {0} {1}, его вес составляет {2}кг\nЕго возраст {3}, а длина хвостика {5} см\n", _name,
                _weight > 45 ? "упитанный" : "голодает", _weight, _age, _kind, _tailLenght);
        }

        public void BuildDam()
        {
            Console.WriteLine("Платина построена!");
        }
    }
}