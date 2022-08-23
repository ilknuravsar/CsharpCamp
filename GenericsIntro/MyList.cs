using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        //constructor - class newlendsiği anda çalışmaya başlar
        public MyList()
        {
            items = new T[0];       
        }
        public void Add(T item)
        {
            //geçici - önceki diziyi tutmak için kullanıyoruz
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length;  }
        }

        public T[] Items
        {
            get { return items; }
        }

    }
}
