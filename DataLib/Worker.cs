using System;

namespace DataLib
{
	/*		Класс Worker
	 * 
	 * Содержит:
	 *	- данные об одном рабочем
	 *	- Способы создания экземпляра класса
	 *	- Методы работы с экземплярами класса
	 * 
	 * Наследование:
	 *	Object -> Worker
	 */
	public class Worker
	{
		public string Name { get; private set; }	//Имя(Фамилия) работника
		public int Number { get; private set; }		//Номер цеха работника
		public bool IsNeed { get; private set; }	//Нуждаемость в жилплощади 

		private int year;                           //Год рождения рабочего
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
		}							//Год рождения как свойство (Работает с полем year)

		//	Конструктор для генерации случайного человека с заданным номером цеха num
		public Worker(int num, Random rnd, in string[] surnames)
		{
			Number = num;
			Name = surnames[rnd.Next(0, 318472)];
			Year = rnd.Next(1940, 2003);
			IsNeed = Convert.ToBoolean(rnd.Next(0, 2));
		}
		//	Стандартный конструктор принимающий все 4 параметра
		public Worker(int num, string name, int year, bool is_need)
		{
			Number = num;
			Name = name;
			Year = year;
			IsNeed = is_need;
		}
		//	Копирует все параметры из worker в this
		public void Copy(Worker worker)
        {
			Number = worker.Number;
			Name = worker.Name;
			Year = worker.Year;
			IsNeed = worker.IsNeed;
        }
	}
}
