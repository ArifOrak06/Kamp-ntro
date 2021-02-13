using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T1, T2>
    {
        T1[] arrKey;
        T2[] arrValue;

        public MyDictionary()
        {
            arrKey = new T1[0];
            arrValue = new T2[0];

        }
        public void Add(T1 item1, T2 item2)
        {
            T1[] tempKey = arrKey;
            T2[] tempValue = arrValue;

            arrKey = new T1[arrKey.Length + 1];
            arrValue = new T2[arrValue.Length + 1];

                // Geçici bir arraya emanet edilen Anahtar değer, yeni eleman sayısı artırılan array'e atanıyor.
            for (int i = 0; i < tempKey.Length; i++)
            {
                arrKey[i] = tempKey[i];
            }
            arrKey[arrKey.Length - 1] = item1;

                // Geçici bir arraya emanet edilen Value değer, yeni eleman sayısı artırılan array'e atanıyor.
            for (int i = 0; i < tempValue.Length; i++)
            {
                arrValue[i] = tempValue[i];

            }
            arrValue[arrValue.Length - 1] = item2;

            
        }
    }
}
