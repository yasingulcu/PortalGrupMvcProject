using PortalGrupMvcProject.Concrete;
using PortalGrupMvcProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PortalGrupMvcProject.Abstract
{
    //Projede BaseCustomerManager sınıfını kullanma amacım iki firmanında kaydetme işlemini yapacak olmasıdır. Ortak bir işlem olduğu için bu sınıfa ihtiyaç duydum.
    //Ayrıca bu sınıfı Abstract olarak tanımladım ki newlenemesin.
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer) //Burada bu metodu virtual yapma amacım bu sınıftan kalıtım alacak sınıflara bu metodu ezme şansları vermek.
        {
          
        }
    }
}