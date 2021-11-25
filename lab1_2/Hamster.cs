using System;

namespace lab1_2
{
    public class Hamster : Rodent
    {
        private int _cheeks; // Размер щечек

        public int Cheeks // Геттер / сеттер
        {
            get => _cheeks;
            set
            {
                _cheeks = value;
                if (_cheeks < 1) _cheeks = 0; // размер щечек не может быть отрицательным 
            }
        }
        
        // Конструктор
        public Hamster(string name = null, int cheeks = 0, string sex = null, int age = 0, string kind = "Хомяк",
            float weight = 0, string detachment = "хомяковые") : base(kind, name, age, sex, weight, detachment)
        {
            _cheeks = cheeks;
        }

        
        public void StartHam() // метод класса
        {
            Console.WriteLine("Начинаем Хомячить :3");
        }

        public override void TimeToFeed() // Вируальный метод
        {
            Console.WriteLine("Время покормить хомяка!");
        }

        public new static void ShowClassName()
        {
            Console.WriteLine("Имя класса: 'Hamster'.");
        }
        
        public override void InputData()
        {
            base.InputData();
            Console.Write("Вместимость щечек (в орешках): ");
            var inputCheeks = Console.ReadLine();
            var isCheekstConverted = int.TryParse(inputCheeks, out var cheeks);
            if (isCheekstConverted)
                _cheeks = cheeks;
            else
                Console.WriteLine("Некорректный ввод.");
            Console.WriteLine("------------------------------------------------");
        }
        
        public override string ToString() // Перегрузка метода ToString;
        {
            if (Sex == "Жен")
                return string.Format(
                    "{4} {0} приветствует!\nНаша девочка {0} {1}, ее вес составляет {2}кг\nЕе возраст {3}, а вместимость щечек {5} орешков\n", _name,
                    _weight > 45 ? "упитанная" : "голодает", _weight, _age, _kind, _cheeks);
            return string.Format(
                "{4} {0} приветствует!\nНаш мальчик {0} {1}, его вес составляет {2}кг\nЕго возраст {3}, а вместимость щечек {5} орешков\n", _name,
                _weight > 45 ? "упитанный" : "голодает", _weight, _age, _kind, _cheeks);
        }

        public void HiddenNuts()
        {
            Console.WriteLine("Сколько орешков вы хотите спрятать?");
            int choice;
            choice = int.Parse(Console.ReadLine());
                
                if (choice > _cheeks)
                    Console.WriteLine($"Вы можете спрятать  только {_cheeks} орешков(");
                else
                    Console.Write("Орешки спрятаны!!!");
        }
    }
}