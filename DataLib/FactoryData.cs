using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLib
{
    public class FactoryData : Dictionary<int,WorkersData>
    {
        public void AddPerson(int num, string name, int year, bool need)
        {
            Worker Person = new Worker(name, year, need);
            this[num].Add(Person);
        }

        public void AddPerson(int num, Random rnd)
        {
            Worker Person = new Worker(rnd);
            
            try
            {
                this[num].Add(Person);
            }
            catch (KeyNotFoundException)
            {
                WorkersData workers = new WorkersData();
                workers.Add(Person);
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

        


    }
}
