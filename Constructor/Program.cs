using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Şimdi ise Customer classından yeni bir obje türetelim, (New)
            Customer customer = new Customer();

            // Customer classından yeni bir obje türetmenin bir başka yolu

            Customer customer2 = new Customer
            {
                Id = 1,
                FirstName = "Arif",
                LastName = "ORAK",
                City = "ANGARA"
            };

            // Customer classından yeni bir obje türetmenin bir başka yolu sanki bir fonksiyonmuş gibi içerisine parametre girerek,
            Customer customer3 = new Customer(2,"Kübra","ORAK","ARDAHAN");
        }
    }
    class Customer
    {
        //Default Constructor..
        public Customer()
        {

        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
