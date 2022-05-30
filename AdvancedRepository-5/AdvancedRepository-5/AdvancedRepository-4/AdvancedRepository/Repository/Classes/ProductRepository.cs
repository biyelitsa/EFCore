using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models;
using AdvancedRepository.Models.Classes;
using AdvancedRepository.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Repository.Classes
{
    public class ProductRepository: BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(CompanyContext db): base(db)
        {

        }

        public List<ProductList> GetProductList()
        {
            return Set().Select(x => new ProductList
            {
                Id = x.Id,
                ProductName = x.ProductName,
                ProductImage=x.ProductImage,
                CategoryName = x.Category.CategoryName,
                CompanyName = x.Supplier.CompanyName,
                UnitName = x.Unit.UnitName,
                EmployeeName=x.Employees.FirstName+" "+x.Employees.Surname,
                EmployeeId=x.Employees.Id,
                Deleted=x.Deleted
         
            }).Where(x=>x.Deleted==false).ToList();
        }

        public List<ProductSelect> GetProductSelect()
        {
            return Set().Select(x => new ProductSelect
            {
                Id=x.Id,
                ProductName=x.ProductName
            }).ToList();
        }

        public List<ProductList> ListByCategoryId(int id)
        {
            return Set().Select(x => new ProductList
            {
                Id = x.Id,
                ProductName = x.ProductName,
                ProductImage = x.ProductImage,
                CategoryName = x.Category.CategoryName,
                CompanyName = x.Supplier.CompanyName,
                UnitName = x.Unit.UnitName,
                EmployeeName = x.Employees.FirstName + " " + x.Employees.Surname,
                EmployeeId = x.Employees.Id,
                CategoryId = x.CategoryId
            }).Where(x => x.CategoryId == id).Include(x=>x.CategoryId).ToList();
        }

        public List<ProductList> RecoverProductList()
        {
            return Set().Select(x => new ProductList
            {
                Id = x.Id,
                ProductName = x.ProductName,
                ProductImage = x.ProductImage,
                CategoryName = x.Category.CategoryName,
                CompanyName = x.Supplier.CompanyName,
                UnitName = x.Unit.UnitName,
                EmployeeName = x.Employees.FirstName + " " + x.Employees.Surname,
                EmployeeId = x.Employees.Id,
                Deleted = x.Deleted
            }).Where(x => x.Deleted == true).ToList();
        }
    }
}
 