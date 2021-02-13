using InterfacesAbstractDemo.Abstract;
using InterfacesAbstractDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationaltyId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year).ConfigureAwait(false);
        }
    }
}
