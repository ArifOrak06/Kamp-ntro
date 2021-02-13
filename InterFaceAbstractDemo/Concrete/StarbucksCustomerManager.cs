using InterFaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterFaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager,ICustomerCheckService
    {
        public void CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }

        public override void Save(Customer customer)
        {
            CheckIfRealPerson(customer);
            base.Save(customer);
        }

   

    }
}
