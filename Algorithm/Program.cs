using System;
using System.Collections.Generic;
using System.Threading;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
			var users = new List<User>
			{
				new User()
                {
					Login = "Ivan",
					Name = "Иван",
					IsPremium = true
                },
				new User()
				{
					Login = "Alexey",
					Name = "Алексей",
					IsPremium = false
				},
				new User()
				{
					Login = "Nikita",
					Name = "Никита",
					IsPremium = false
				},
				new User()
				{
					Login = "Oleg",
					Name = "Олег",
					IsPremium = true
				}
			};

			foreach (var user in users)
            {
				if (user.IsPremium)
                {
					ShowGreeting(user.Name);
                }
				else
                {
					ShowGreeting(user.Name);
					ShowAds();
				}

				Console.WriteLine();
            }

			Console.ReadKey();
        }

		/// <summary>
		/// Показать рекламу
		/// </summary>
		private static void ShowAds()
		{
			Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
			// Остановка на 1 с
			Thread.Sleep(1000);

			Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
			// Остановка на 2 с
			Thread.Sleep(2000);

			Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
			// Остановка на 3 с
			Thread.Sleep(3000);
		}

		/// <summary>
		/// Показать приветствие
		/// </summary>
		/// <param name="name">Имя пользователя</param>
		private static void ShowGreeting(string name)
        {
			Console.WriteLine("Добрый день, {0}!", name);
        }
	}
}
