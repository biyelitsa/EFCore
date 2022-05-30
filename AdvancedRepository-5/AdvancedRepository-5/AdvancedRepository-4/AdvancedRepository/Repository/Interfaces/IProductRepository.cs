using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Repository.Interfaces
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        List<ProductList> GetProductList();
        List<ProductSelect> GetProductSelect();
        List<ProductList> RecoverProductList();
        List<ProductList> ListByCategoryId(int id);
        
    }
}
