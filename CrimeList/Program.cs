namespace Criminals
{
    class Programm
    {
        static void Main()
        {
            Menu menu = new Menu();
            menu.Run();
            
        }
    }

    class Menu
    {
        private const string ShowAllCommand = "1";
        private const string HeightFindCommand = "2";
        private const string WeightFindCommand = "3";
        private const string NationalityFindCommand = "4";
        private const string Exit = "0";

        public void Run()
        {
            string userInput;
            bool isExit = false;
            int menuPositionY = 0;

            DataBase dataBase = new DataBase();
            dataBase.CreateCriminals();
            

            while (isExit == false)
            {
                Console.WriteLine(ShowAllCommand + " - Показать всех");
                Console.WriteLine(HeightFindCommand + " - Поиск по росту");
                Console.WriteLine(WeightFindCommand + " - Поиск по весу");
                Console.WriteLine(NationalityFindCommand + " - Поиск по национальности");
                Console.WriteLine(Exit + " - Выход\n");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case ShowAllCommand:
                        dataBase.ShowAllCriminals();
                        break;

                    case HeightFindCommand:
                        //service.CreateClients(_clientsToCreate);
                        break;

                    case WeightFindCommand:
                        //_service.StorageMenu();
                        break;

                    case NationalityFindCommand:
                        //_service.StorageMenu();
                        break;

                    case Exit:
                        isExit = true;
                        break;
                }
            }
        }

        // - Всех посмотреть
        // - Поиск по росту
        // - Поиск по весу
        // - Поиск по национальности
        // - Выход
    }

    class Criminal
    {
        public Criminal()
        {
            Name = GetName();
            Nationality = GetNationality();
            Height = GetHeight();
            Weight = GetWeight();
            isImprisoned = GetImprisonmentStatus();
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
        "Яна Афёра",
        "Витя Застрелю",
        "Паша Кабриолет",
        "Коля Чмырь",
        "Миша Мафиозник"
            };

            string name = criminalNames[Utils.GetRandomNumber(criminalNames.Length - 1)];
            return name;
        }

        private string GetNationality()
        {
            string[] nationalityes = new string[]
            {
        "Русский",
        "Украинец",
        "Белорус",
        "Казах",
        "Узбек",
        "Таджик",
        "Туркмен",
        "Киргиз",
        "Армянин",
        "Азербайджанец",
        "Молдаванин",
        "Грузин",
        "Киргиз",
        "Туркмен",
        "Татарин",
        "Башкир",
        "Чуваш",
        "Абхаз",
        "Осетин",
        "Крымчанин",
        "Карел",
        "Эстонец",
        "Латыш",
        "Литовец",
        "Удмурт",
        "Марий",
        "Чеченец",
        "Ингуш",
        "Дагестанец",
        "Калмык",
        "Чеченец",
        "Коми",
        "Тувинец",
        "Хакас",
        "Якут",
        "Бурят",
        "Чукча",
        "Эвенк",
        "Ненец",
        "Карачаевец",
        "Бурят",
        "Гагауз",
        "Лак",
        "Кумык",
        "Каргинец",
        "Авар",
        "Татарстанец",
        "Брянчанин",
        "Кубанец",
        "Сибиряк",
        "Дончанин"
            };

            string nationality = nationalityes[Utils.GetRandomNumber(nationalityes.Length - 1)];
            return nationality;
        }

        private int GetWeight()
        {
            int minWeight = 50;
            int maxWeight = 150;

            return Utils.GetRandomNumber(minWeight, maxWeight);
        }

        private int GetHeight()
        {
            int minHeight = 150;
            int maxHeight = 220;

            return Utils.GetRandomNumber(minHeight, maxHeight);
        }

        private bool GetImprisonmentStatus()
        {
            bool isImprisoned = false;

            if (Utils.GetRandomNumber(2) == 1)
            {
                isImprisoned = true;
            }

            return isImprisoned;
        }
    }

    class DataBase
    {
        private int ammountOfRecords = 20;
        private List<Criminal> _criminals = new List<Criminal>();

        public void ShowAllCriminals()
        {
            string imprisonmentStatus;

            for (int i = 0; i < _criminals.Count; i++)
            {
                if (_criminals[i].isImprisoned == true)
                {
                    imprisonmentStatus = "В тюрьме";
                }
                else
                {
                    imprisonmentStatus = "На свободе";
                }

                Console.WriteLine($"{_criminals[i].Name}, {_criminals[i].Nationality}, Рост {_criminals[i].Height}, Вес {_criminals[i].Weight}, {imprisonmentStatus}");
            }
        }

        public void CreateCriminals()
        {
            for (int i = 0; i < ammountOfRecords; i++)
            {
                _criminals.Add(new Criminal());
            }
        }
    }

    class Utils
    {
        private static Random s_random = new Random();

        public static int GetRandomNumber(int minValue, int maxValue)
        {
            return s_random.Next(minValue, maxValue);
        }

        public static int GetRandomNumber(int maxValue)
        {
            return s_random.Next(maxValue);
        }
    }
}
    
//У нас есть список всех преступников.
//В преступнике есть поля: ФИО, заключен ли он под стражу, рост, вес, национальность.
//Вашей программой будут пользоваться детективы.
//У детектива запрашиваются данные (рост, вес, национальность), 
//и детективу выводятся все преступники, которые подходят под эти параметры, но уже заключенные под стражу выводиться не должны. 