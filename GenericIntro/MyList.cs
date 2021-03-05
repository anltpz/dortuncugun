using System;
using System.Collections.Generic;
using System.Text;

namespace GenericIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()// newledigim anda calısan bloga constructor denir
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] temps = items;
            items = new T[items.Length + 1];

        }
    }
}
