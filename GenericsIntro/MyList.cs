using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //Kendimiz bir liste yapısı oluşturuyoruz.
    // "T" koyma sebebimiz bu listede T gibi tek bir değerle çalışcağımızı belirtmekte.
    class MyList <T> //Lİst yapısının temel mantığı içinde tanımlanan bir diziyi yönetmektir.
    {
        T[] items; //veri tipini kullanım esnasında belirliceğiz bu yüzden T tipinde verdik.
        //constructor
        public MyList() // Class bir yerde newlenirse otomatik olarak çalışır!
        {
            items = new T[0];
        }
        public void Add(T item) // biz bu metodu kullanırken "T" yerine istediğimiz bir veri tipi vericeğiz !
        {
            T[] tempArray = items; //refensımızı tutmak için bu geçici diziyi kullandık.
            items = new T[items.Length + 1]; // eleman eklerlerken dizide yer açmak için kullanıyoruz!
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // burda sakladığımız referans değerini dizimize geri verdik.

            }

            items[items.Length - 1] = item;
        }
    }
}
