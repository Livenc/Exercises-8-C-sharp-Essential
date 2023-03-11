namespace Exercise_5;


class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть дату свого народження (у форматі ДД.ММ.РРРР): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            DateTime today = DateTime.Today;

            DateTime nextBirthday = new DateTime(today.Year, birthdate.Month, birthdate.Day);

            if (nextBirthday < today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }

            TimeSpan daysUntilBirthday = nextBirthday - today;

            Console.WriteLine($"До наступного дня народження залишилось: {daysUntilBirthday.Days} днів");
        Console.ReadKey();
        }
    }


