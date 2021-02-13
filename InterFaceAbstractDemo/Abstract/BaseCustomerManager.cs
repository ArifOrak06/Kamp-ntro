using System;
using System.Collections.Generic;
using System.Text;

namespace InterFaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public void Save(Customer customer)
        {
            Console.WriteLine("Veri Tabanına Kaydedildi : " + customer.FirstName);
        }
    }
}
