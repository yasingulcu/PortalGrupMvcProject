using PortalGrupMvcProject.Abstract;
using PortalGrupMvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalGrupMvcProject.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager //BaseCustomerManagerı kalıtım aldık. Çünkü kaydetme işlemi Portal şirketinde de kullanılacak.
    {
        ICustomerCheckService _customerCheckService;


        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        // Yukarıda constructor metodunu kullandık. Çünkü amacımız kontrol servisine bağımlılığı en az indirmek.

        public override void Save(Customer customer) // Burada kişinin gerçek bir kişi olup olmadığını kontrol ediyoruz. Gerçek bir kişiyse veritabanına ekliyor değilse hata mesajı veriyor.
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Kişi Eklenemedi");
            }
        }
    }
}