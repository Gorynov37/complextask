using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataLib
{
    class WorkersData : Dictionary<string,Worker>
    {
        public int IsNeedAmount()
        {
            int amount = 0;

            foreach (KeyValuePair<string, Worker> p in this)
            {
                if (p.Value.IsNeed) { amount++; }
            }

            return amount;
        }
        public Worker FindPriority()
        {
            Worker Person = new Worker("", 2000, false);
            int min_year = 3000;
            
            foreach(KeyValuePair<string, Worker> p in this)
            {
                if ((p.Value.IsNeed) && (p.Value.Year < min_year))
                {
                    Person.Copy(p.Value);
                }
            }

            return Person;
        }

        public void Add(Worker p) => Add(p.Name, p);
    }
}
