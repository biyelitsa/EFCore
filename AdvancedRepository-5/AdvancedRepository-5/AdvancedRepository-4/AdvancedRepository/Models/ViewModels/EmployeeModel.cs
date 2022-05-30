using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Models.ViewModels
{
    public class EmployeeModel
    {
   
        public Employee Employee { get; set; }
        public string BtnClass { get; set; }
        public string BtnVal { get; set; }
        public string Title { get; set; }
        public List<ManagerList> ManagerList { get; set; }
        public List<CountyList> CountyList { get; set; }
    }
}
