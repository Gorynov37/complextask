using System;

namespace DataLib
{
	public class Worker
	{
		private int year;
		public string Name { get; private set; }
		public bool IsNeed { get; private set; }
		public int Year
		{
			get
			{
				return year;
			}
			private set
			{
				if ((value < 2003) && (value > 1900))
				{
					year = value;
				}
				else
				{
					throw new Exception("Ошибка: Введён неверный год рождения");
				}
			}
		}

		public Worker(Random rnd)
		{
			Name = RandomName(rnd);
			Year = rnd.Next(1920, 2002);
			IsNeed = Convert.ToBoolean(rnd.Next(0, 2));
		}

		public Worker(string name, int year, bool is_need)
		{
			Name = name;
			Year = year;
			IsNeed = is_need;
		}

		private string RandomName(Random rnd)
        {
			char[] UpLetters = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЭЮЯ".ToCharArray();
			char[] Letters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
			string name = "";

			for (int i = 1; i < 10; i++)
            {
				if (i == 1) { name += UpLetters[rnd.Next(0, 29)]; }
				else { name += Letters[rnd.Next(0, 32)]; }
            }

			return name;
        }

		public void Copy(Worker p)
        {
			this.Name = p.Name;
			this.Year = p.Year;
			this.IsNeed = p.IsNeed;
        }
	}
}
