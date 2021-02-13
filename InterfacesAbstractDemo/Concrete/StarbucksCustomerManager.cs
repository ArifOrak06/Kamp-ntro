using InterfacesAbstractDemo.Abstract;
using InterfacesAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAbstractDemo.Concrete
{
    class StarbucksCustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Doğru bir kişi değil");
            }
            
           
        }

       
    }
}
