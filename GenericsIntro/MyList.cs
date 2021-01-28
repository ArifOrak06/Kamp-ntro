using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        
        T[] items;
        //Constructor  = aslında bir methoddur, bu classı bir yerde newlersen otomatik olarak çalışır.
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) // Yukarıda oluşturmuş olduğumuz 0 indexli T tipli arrayi ekleme işlemi yapacağımız için burada eleman sayısını 1 artırma işlemi yani ekleme methodunu yazdık.
        {
            T[] tempArray = items;  // Aşağıda tanımlanan eleman sayısının 1 artırıldığında eski array yol olmasın diye tempArray'i tanımladık.
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];   
            }
            // Yukarıda for döngüsü ile eleman sayısı 1 artırılarak oluşturulan array'in yokettiği değerleri tutan tempArray'in verilerini bire bir olarak eleman sayısı artırılan yeni items arrayine atadık.
            items[items.Length - 1] = item;  // Burada ise yukarıda eşitlenen yeni arraydan kalan artırılan son indexe veri ekledik. 
        }
       
    }
}
