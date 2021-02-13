using System;

namespace ReferenceAndValuesTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı1 = 10;
            int sayı2 = 20;

            sayı1 = sayı2;
            sayı2 = 200;
            Console.WriteLine("sayı1 : " + sayı1);

            // Cevap : 20   ----> int,decimal, float, enum, boolean sayılsal olan değişkenler aslında değer tipdir. Bu yüzden  değişken eşitleme işlemlerinde
            // sadece değerini değiştirirsiniz, değişkeni değil, sayı1'i sayı2'ye eşitleme işleminde de bu böyledir. Daha sonra sayı2'nin değerini 
            // değiştirsenizde sayı1'in değeri değişmeyecektir ilk eşitlemede sayı 2'nin değerine eşit olacaktır. 

            // Referans Tipler

            int[] sayılar1 = new int[] { 1, 2, 3 };
            int[] sayılar2 = new int[] { 10, 20, 30 };

            sayılar1 = sayılar2;
            sayılar1[1] = 200;
            sayılar2[0] = 100;

            Console.WriteLine(sayılar2[1]);
            Console.WriteLine(sayılar1[0]);

            //Cevap : 100'dür . Çünkü bu sefer yukarıdaki örnek ile karıştırmayın, bu kez referans tipleri ele aldık, yani referans tiplerde adres bağlantısı değişir
            // bundan sonra sayılar2'nin hangi indexi değişirse sayılar1'in de o indexi değişecektir. Çünkü eşitleme işlemi yaptığımızda adres eşitlemesi yaptık ve 
            // bir önceki bellekteki adresi silinde her iki değişkenimizin adres bağlantısı aynı oldu eşitleme işlemi yaptığımız için. Eşitleme işleminde sonra herhangi
            // bir değişkende yapılacak değişiklik diğer array'i de etkileyecektir.

            // ** Bu durum class ve interfacelerde de aynıdır. Onlarda birer referans tiplerdir. Örnek verecek olursak;

            Person person1 = new Person();
            person1.FirstName = "Arif";
            person1.LastName = " ORAK";

            Person person2 = new Person();
            person2 = person1;

            Employee employee1 = new Employee();
            employee1.FirstName = "Emir";
            Console.WriteLine(person2.FirstName + person2.LastName);

            // Yukarıda da görüldüğü gibi bir eşitleme yaparak person2 için herhangi bir metod bilgisini vermeden person1'in metod bilgisi atandı. Çünkü adres eşitlemesi yapıldı.
            // Artık person1'de yapılacak her bir değişiklik otomatik olarak person2'de de yer alacaktır. 

            PersonManager personManager = new PersonManager();
            personManager.Add(employee1);

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }

    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }

    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
