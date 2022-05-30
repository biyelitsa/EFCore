using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.ViewModels
{
    public class ProductModel
    {
 
        public Product Product { get; set; }
        public string BtnClass { get; set; }
        public string BtnVal { get; set; }
        public string Title { get; set; }
        public List<CategoryList> CategoryList { get; set; }
        public List<SupplierList> SupplierList { get; set; }
        public List<UnitList> UnitList { get; set; }
        public List<EmployeeList> EmployeeList { get; set; }
    }
}
