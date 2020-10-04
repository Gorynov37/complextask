using System;
using System.Collections.Generic;
using System.IO;

namespace DataLib
{
    public class FactoryData : SortedDictionary<int,WorkersData>
    {
        public void AddPerson(int num, string name, int year, bool need)
        {
            Worker Person = new Worker(num, name, year, need);
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
