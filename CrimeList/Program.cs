namespace Criminals
{
    class Programm
    {
        static void Main()
        {
            Menu menu = new Menu();
            menu.ShowMainMenu();
        }
    }

    class Menu
    {

    }

    class Criminal
    {
        public Criminal()
        {

        }

        public string Name { get; private set; }
        public string Nationality { get; private set; }
        public int Height { get; private set; }
        public int Weight { get; private set; }
        public bool isImprisoned { get; private set; }


        private string GetName()
        {
            string[] criminalNames = new string[]
            {
        "Толя Руль",
        "Вася Шнырь",
        "Петруха Кабан",
        "Гриша Гопник",
        "Дима Толкач",
        "Санек Бульба",
        "Женя Лапоть",
        "Коля Барсук",
        "Леша Халтурка",
        "Сергей Косой",
        "Миша Череп",
        "Олег Огурец",
        "Игорь Чебурек",
        "Витя Колотушка",
        "Юра Мясник",
        "Андрей Бычок",
        "Макс Карась",
        "Павел Колесо",
        "Саша Котлета",
        "Кирилл Бутерброд",
        "Артем Брызгало",
        "Денис Крошка",
        "Никита Пельмень",
        "Стас Пельменище",
        "Ольга Гречка",
        "Елена Блинная",
        "Таня Лапша",
        "Алиса Пирожок",
        "Вика Щи",
        "Яна Пельменина"
            };

            string name = criminalNames[Random.Next(0, criminalNames.Length - 1)];
            return name;
        }

        private int GetWeight()
        {
            int weight = 0;

            return weight;
        }

        private int GetHight()
        {
            int height = 0;

            return height;
        }

    }


}

//У нас есть список всех преступников.
//В преступнике есть поля: ФИО, заключен ли он под стражу, рост, вес, национальность.
//Вашей программой будут пользоваться детективы.
//У детектива запрашиваются данные (рост, вес, национальность), 
//и детективу выводятся все преступники, которые подходят под эти параметры, но уже заключенные под стражу выводиться не должны. 