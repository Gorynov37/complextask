using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib
{
    class FactoryData : Dictionary<int,WorkersData>
    {
        public void AddPerson(int num, string name, int year, bool need)
        {
            Worker Person = new Worker(name, year, need);
            this[num].Add(Person);
        }
    }
}
