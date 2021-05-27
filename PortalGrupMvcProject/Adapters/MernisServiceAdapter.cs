using PortalGrupMvcProject.Abstract;
using PortalGrupMvcProject.MernisServiceReference1;
using PortalGrupMvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalGrupMvcProject.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService 
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }
    }
    //ICustomerCheckService inteface ini kalıtsal olara buraya ekledik. Çünkü içindeki fonksiyonu burda doldurmamız gerekli. Mernis Sistemini uygulayarak burada doldurduk.
    //Burada fonksiyon artık Mernis Sistemine gidiyor. Eklenecek kişinin gerçek bir kişi olup olmadığını sorguluyor.
}