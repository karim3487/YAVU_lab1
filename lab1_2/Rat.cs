using System;

namespace lab1_2
{
    public class Rat : Rodent
    {

        private string _coatColor;
        
        public string CoatColor
        {
            get => _coatColor; // длина хваста
            set
            {
                _coatColor = value;
            }
        }
        
        public Rat(string name = null, string coatColor = null, string sex = null, int age = 0, string kind = "Крыса",
            float weight = 0, string detachment = "мышинные") : base(kind, name, age, sex, weight, detachment)
        {
            _coatColor = coatColor;
        }

        
        public void StartRat() // метод класса
        {
            Console.WriteLine("Начинаем КРЫСЯТНИЧАТЬ :3");
        }

        public override void TimeToFeed() // Вируальный метод
        {
            Console.WriteLine("Время покормить крыску!");
        }

        public new static void ShowClassName()
        {
            Console.WriteLine("Имя класса: 'Rat'.");
        }
        
        public override void InputData()
        {
            base.InputData();
            Console.Write("Цвет шерстки: ");
            _coatColor = Console.ReadLine();
            Console.WriteLine("------------------------------------------------");
        }
        
        public override string ToString() // Перегрузка метода ToString;
        {
            if (Sex == "Жен")
                return string.Format(
                    "{4} {0} приветствует!\nНаша девочка {0} {1}, ее вес составляет {2}кг\nЕе возраст {3}, а цвет шерстки {5}\n", _name,
                    _weight > 45 ? "упитанная" : "голодает", _weight, _age, _kind, _coatColor);
            return string.Format(
                "{4} {0} приветствует!\nНаш мальчик {0} {1}, его вес составляет {2}кг\nЕго возраст {3}, а цвет шерстки {5}\n", _name,
                _weight > 45 ? "упитанный" : "голодает", _weight, _age, _kind, _coatColor);
        }

        public void EatCheese()
        {
            Console.WriteLine("Ням-ням-ням...");
            Console.WriteLine("Сыр съеден!!!");
        }
    }
}