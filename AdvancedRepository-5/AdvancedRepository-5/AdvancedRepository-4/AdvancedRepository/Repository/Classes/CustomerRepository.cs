using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models;
using AdvancedRepository.Models.Classes;
using AdvancedRepository.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedRepository.Repository.Classes
{
    public class CustomerRepository: BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(CompanyContext db): base(db)
        {

        }

        public List<CustomerList> GetCustomerList()
        {
            return Set().Select(x => new CustomerList
            {
                CustomerId = x.Id,
                CustomerName = x.CompanyName,
                FullAddress = $"{x.Street} St., {x.Avenue} Ave., No: {x.OutDoorNumber}, County: {x.County.CountyName}",
                PhoneNumber = x.PhoneNumber,
                Rating = x.Rating,
                Deleted=x.Deleted
              
            }).Where(x=>x.Deleted==false).ToList();
        }

        public List<CustomerSelect> GetCustomerSelect()
        {
            return Set().Select(x => new CustomerSelect
            {
                Id=x.Id,
                CompanyName=x.CompanyName
            }).ToList();
        }

        public List<CustomerList> RecoverCustomerList()
        {
            return Set().Select(x => new CustomerList
            {
                CustomerId = x.Id,
                CustomerName = x.CompanyName,
                FullAddress = $"{x.Street} St., {x.Avenue} Ave., No: {x.OutDoorNumber}, County: {x.County.CountyName}",
                PhoneNumber = x.PhoneNumber,
                Rating = x.Rating,
                Deleted = x.Deleted

            }).Where(x => x.Deleted == true).ToList();
        }
    }
}
