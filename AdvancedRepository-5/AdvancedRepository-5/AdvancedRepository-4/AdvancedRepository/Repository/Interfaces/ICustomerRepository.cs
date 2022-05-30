using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using System.Collections.Generic;

namespace AdvancedRepository.Repository.Interfaces
{
    public interface ICustomerRepository: IBaseRepository<Customer>
    {
        List<CustomerList> GetCustomerList();
        List<CustomerList> RecoverCustomerList();
        List<CustomerSelect> GetCustomerSelect();
    }
}
