using PortalGrupMvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalGrupMvcProject.Abstract
{
    // Bu interface kaydetme fonksiyonunu barındırır.
    public interface ICustomerService 
    {
        void Save(Customer customer);
    }
}
