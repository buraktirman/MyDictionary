using System;

namespace MyDictionary
{
    internal class MyDictionary<T, K>
    {
        Tuple<T, K>[] items;

        public MyDictionary()
        {
            items = new Tuple<T, K>[0];
        }

        public int Count
        {
            get { return items.Length; }
        }

        public void Add(T key, K value)
        {
            if (ControlKey(key))
            {
                Tuple<T, K>[] tempDictionary = items;
                items = new Tuple<T, K>[items.Length + 1];

                for (int i = 0; i < tempDictionary.Length; i++)
                {
                    items[i] = tempDictionary[i];
                }

                items[items.Length - 1] = new Tuple<T, K>(key, value);
            }
            else
            {
                Console.WriteLine("Key değeri daha önce kullanılmamış olmalıdır!");
            }

        }

        public void ShowDictionary()
        {
            Console.WriteLine("-----Key : Value-----");
            foreach (var item in items)
            {
                Console.WriteLine(item.Item1 + " : " + item.Item2);
            }
        }

        private bool ControlKey(T key)
        {
            bool flag = true;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Item1.ToString() == key.ToString())
                {
                    flag = false;
                }
            }
            return flag;
        }

    }
}

