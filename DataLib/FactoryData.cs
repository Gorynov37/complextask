using System;
using System.Collections.Generic;
using System.IO;

namespace DataLib
{
    /*      Класс FactoryData
     * 
     * Представляет из себя словарь - двоичное дерево поиска
     *  с номером цеха в качестве ключа
     *  и с объектом класса WorkersData(Рабочие этого цеха) в качестве элемента.
     *  
     * Содержит методы добавления информации о рабочих, чтения/записи файлов с данными.
     * 
     * Наследование:
     *  Object -> SortedDictionary<int,WorkersData> -> FactoryData
     */
    public class FactoryData : SortedDictionary<int,WorkersData>
    {
        //  Добавление рабочего по всем 4 параметрам.
        //Добавляет элемент класса Worker в словарь(WorkersData) с рабочими данного цеха.
        public void AddPerson(int num, string name, int year, bool need)
        {
            Worker Person = new Worker(num, name, year, need);
            if (this.ContainsKey(num)) 
            {
                this[num].Add(Person);
            }
            else
            {
                WorkersData workers = new WorkersData { Person };
                Add(num, workers);
            }
        }

        //  Добавление случайно сгенерированного рабочего
        //с данным номером цеха и с фамилией из данного массива строк.
        public void AddPerson(int num, Random rnd, in string[] surnames)
        {
            Worker Person = new Worker(num, rnd, in surnames);
            
            try
            {
                this[num].Add(Person);
            }
            catch (KeyNotFoundException)
            {
                WorkersData workers = new WorkersData { Person };
                Add(num, workers);
            }
        }

        //  Заполняет словарь случайными данными о рабочих
        //с помощью метода AppPerson с фамилиями из файла SurnameBase.txt
        public void RandomInit(int n, int m)
        {
            Random rnd = new Random();
            StreamReader sw = new StreamReader(@"SurnameBase.txt");
            string[] surnames = new string[318472];
            for (int i = 0; i < 318472; i++)
            {
                surnames[i] = sw.ReadLine();
            }

            for (int i = 0; i<n; i++)
            {
                int num = rnd.Next(1, m+1);
                this.AddPerson(num, rnd, in surnames);
            }
        }

        //  Записывает все данные в файл txt
        public void WriteTxt(string path)
        {
            StreamWriter sw = new StreamWriter(path);

            foreach (KeyValuePair<int, WorkersData> d in this)
            {
                foreach (KeyValuePair<string, Worker> p in d.Value)
                {
                    sw.WriteLine($"{p.Value.Name}\n     {p.Value.Number}\n     {p.Value.Year}\n     {p.Value.IsNeed}");
                }
            }
            sw.Close();
        }

        //  Записывает в файл txt результаты обработки данных 
        //полученные применением методов IsNeedAmount() и FindPriority() к каждому элементу
        public void WriteResultTxt(string path)
        {
            StreamWriter sw = new StreamWriter(path);

            foreach (KeyValuePair<int, WorkersData> d in this)
            {
                sw.WriteLine($"\nИнформация по цеху №{d.Key}:");
                sw.WriteLine($"    Нужно Квартир: {d.Value.IsNeedAmount()}");
                sw.WriteLine($"    Приоритетный рабочий: {d.Value.FindPriority().Name} ({d.Value.FindPriority().Year})\n");
            }
            sw.Close();
        }

        //  Считывает данные из файла txt
        //и добавляет в словарь с помощью метода AppPerson
        public void ReadTxt(Stream path)
        {
            StreamReader sw = new StreamReader(path);

            string name = "";
            string num_ = "";
            string year_ = "";
            string need_ = "";
            while (((name = sw.ReadLine()) != null)&&
                   ((num_ = sw.ReadLine()) != null)&&
                   ((year_ = sw.ReadLine()) != null)&&
                   ((need_ = sw.ReadLine()) != null))
            {
                name = name.Trim();
                int num = Convert.ToInt32(num_.Trim());
                int year = Convert.ToInt32(year_.Trim());
                bool need = Convert.ToBoolean(need_.Trim());

                this.AddPerson(num, name, year, need);
            }
        }
    }
}
