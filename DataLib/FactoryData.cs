using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace DataLib
{
    public class FactoryData : Dictionary<int,WorkersData>
    {
        public void AddPerson(int num, string name, int year, bool need)
        {
            Worker Person = new Worker(num, name, year, need);
            this[num].Add(Person);
        }

        public void AddPerson(int num, Random rnd)
        {
            Worker Person = new Worker(num, rnd);
            
            try
            {
                this[num].Add(Person);
            }
            catch (KeyNotFoundException)
            {
                WorkersData workers = new WorkersData { Person };
                this.Add(num, workers);
            }
        }

        public void RandomInit(int n)
        {
            Random rnd = new Random();
            for(int i = 0; i<n; i++)
            {
                int num = rnd.Next(1, n/10);
                this.AddPerson(num, rnd);
            }
        }

        public void WriteToJson(string path)
        {
            path = @"C:\Users\goryn\Desktop\data.txt";
            var options = new JsonSerializerOptions { WriteIndented = true };

            foreach (KeyValuePair<int, WorkersData> d in this)
            {
                foreach (KeyValuePair<string, Worker> p in d.Value)
                {
                    string json = JsonSerializer.Serialize<Worker>(p.Value, options);
                    System.IO.File.WriteAllText(path, json);
                }

            }

        }

    }
}
