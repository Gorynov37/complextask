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

		public Worker(string name, int year, bool is_need)
		{
			Name = name;
			Year = year;
			IsNeed = is_need;
		}
	}
}
