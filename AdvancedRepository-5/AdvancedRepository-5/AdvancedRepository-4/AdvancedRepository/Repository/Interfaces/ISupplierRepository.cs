using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using System.Collections.Generic;

namespace AdvancedRepository.Repository.Interfaces
{
    public interface ISupplierRepository : IBaseRepository<Supplier>
    {
        List<SupplierList> GetSupplierList();
        List<SupplierList> RecoverSupplierList();
    }
}
