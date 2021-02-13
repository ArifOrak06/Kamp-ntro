using InterfacesAbstractDemo.Abstract;
using InterfacesAbstractDemo.Concrete;
using System;

namespace InterfacesAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Entities.Customer
            {
                FirstName = "Arif",
                LastName = "ORAK",
                DateOfBirth = new DateTime(1991, 7, 4),
                NationaltyId = "28078829262"
            });

        }
    }
}
