using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<T,K>
    {
        KeyValuePair<T, K>[] items;

        public MyDictionary()
        {
            items = new KeyValuePair<T, K>[0];
        }

        public void Add(T _key, K _value)
        {
            bool control = true;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Key.ToString()==_key.ToString())
                {
                    control = false;
                }
            }
            //kontrol yaptırdık sebebi ise key değeri benzersiz olmalı


            if (control==true)
            {
                KeyValuePair<T, K>[] tempArray = items;
                items = new KeyValuePair<T, K>[tempArray.Length + 1];
                for (int i = 0; i < tempArray.Length; i++)
                {
                    items[i] = tempArray[i];
                }
                items[items.Length - 1] = new KeyValuePair<T, K>(_key,_value);
            }
            else
            {
                Console.WriteLine("Girdiğiniz Key Benzersiz Olmalı!");
            }
        }


        public void Show()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

        }

        public int Count
        {
            get { return items.Length; }
        }


    }
}
