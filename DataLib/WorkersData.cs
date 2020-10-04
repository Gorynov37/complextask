using System;
using System.Collections.Generic;

namespace DataLib
{
    /*
     * 
     */
    public class WorkersData : SortedDictionary<string,Worker>
    {
        public int IsNeedAmount()
        {
            int amount = 0;

            foreach (KeyValuePair<string, Worker> p in this)
            {
                if (p.Value.IsNeed == true) { amount++; }
            }

            return amount;
        }
        public Worker FindPriority()
        {
            Worker Person = new Worker(0, "", 2000, false);
            int min_year = 2004;
            
            foreach(KeyValuePair<string, Worker> p in this)
            {
                if ((p.Value.IsNeed) && (p.Value.Year < min_year))
                {
                    Person.Copy(p.Value);
                    min_year = p.Value.Year;
                }
            }

            return Person;
        }

        public void Add(Worker p) => Add(p.Name, p);
    }
}
