using PortalGrupMvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalGrupMvcProject.Abstract
{
    // Bu interface veritabanına eklenecek kişinin gerçek bir kişi olup olmadığını kontrol edecek fonksiyonu barındırır.
    public interface ICustomerCheckService 
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
