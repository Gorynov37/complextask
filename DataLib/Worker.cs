using System;

namespace DataLib
{
	public class Worker
	{
		private int year;
		public string Name { get; private set; }
		public int Number { get; private set; }
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

		public Worker(int num, Random rnd, in string[] surnames)
		{
			Number = num;
			Name = surnames[rnd.Next(0, 318472)];
			Year = rnd.Next(1940, 2003);
			IsNeed = Convert.ToBoolean(rnd.Next(0, 2));
		}

		public Worker(int num, string name, int year, bool is_need)
		{
			Number = num;
			Name = name;
			Year = year;
			IsNeed = is_need;
		}

		public void Copy(Worker p)
        {
			this.Name = p.Name;
			this.Year = p.Year;
			this.IsNeed = p.IsNeed;
        }
	}
}
