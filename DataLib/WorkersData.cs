using System;
using System.Collections.Generic;

namespace DataLib
{
    /*      Класс WorkersData
     * 
     * Представляет из себя словарь - двоичное дерево поиска 
     *  с именем рабочего в качестве ключа
     *  и с объектом класса Worker(информация о рабочем) в качестве элемента.
     *  
     * Содержит методы добавления и обработки данных.
     * 
     * Наследование:
     *  Object -> SortedDictionary<string,Worker> -> WorkersData
     */
    public class WorkersData : SortedDictionary<string,Worker>
    {
        //  Возвращает количество необходимых квартир(Кол-во нуждающихся в жилплощади)
        public int IsNeedAmount()
        {
            int amount = 0;

            foreach (KeyValuePair<string, Worker> p in this)
            {
                if (p.Value.IsNeed == true) { amount++; }
            }

            return amount;
        }

        //  Возвращает приоритетного(самого старшего) рабочего нуждающегося в жилплощади
        public Worker FindPriority()
        {
            Worker Person = new Worker(0, "", 2002, false);
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

        //  Метод добавления элемента.
        //Переопределяется от метода Add() из класса SortedDictionary<string,Worker>.
        public void Add(Worker p) => Add(p.Name, p);
    }
}
