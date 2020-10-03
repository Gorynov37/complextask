using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

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
            StreamReader sw = new StreamReader(@"..\SurnameBase.txt");
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

        public void WriteTxt(string path = @"C:\Users\goryn\Desktop\text.txt")
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

        public void ReadTxt(int n, string path = @"C:\Users\goryn\Desktop\text.txt")
        {
            StreamReader sw = new StreamReader(path);

            for(int i = 0; i < n; i++)
            {
                string name = sw.ReadLine().Trim();
                int num = Convert.ToInt32(sw.ReadLine().Trim());
                int year = Convert.ToInt32(sw.ReadLine().Trim());
                bool need = Convert.ToBoolean(sw.ReadLine().Trim());

                AddPerson(num, name, year, need);
            }
            sw.Close();
        }
    }
}
