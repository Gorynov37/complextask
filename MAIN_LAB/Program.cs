using System;
using System.Collections.Generic;
using DataLib;
using System.IO;

namespace Main_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = 100;
            int m = 7;
            FactoryData data1 = new FactoryData();

            data1.RandomInit(n,m);
            data1.WriteTxt();

            FactoryData data = new FactoryData();
            data.ReadTxt(n);

            foreach(KeyValuePair<int, WorkersData> d in data)
            {
                foreach(KeyValuePair<string, Worker> p in d.Value)
                {
                    Console.WriteLine($"{p.Value.Name}     {p.Value.Number}     {p.Value.Year}     {p.Value.IsNeed} ");
                }

                Console.WriteLine($"\nИнформация по цеху №{d.Key}:");
                Console.WriteLine($"    Нужно Квартир: {d.Value.IsNeedAmount()}");
                Console.WriteLine($"    Приоритетный рабочий: {d.Value.FindPriority().Name} ({d.Value.FindPriority().Year})\n");
            }

            StreamWriter sw = new StreamWriter(@"C:\Users\goryn\Desktop\ResultText.txt");

            foreach (KeyValuePair<int, WorkersData> d in data)
            {
                sw.WriteLine($"\nИнформация по цеху №{d.Key}:");
                sw.WriteLine($"    Нужно Квартир: {d.Value.IsNeedAmount()}");
                sw.WriteLine($"    Приоритетный рабочий: {d.Value.FindPriority().Name} ({d.Value.FindPriority().Year})\n");
            }
            sw.Close();
        }
    }
}
