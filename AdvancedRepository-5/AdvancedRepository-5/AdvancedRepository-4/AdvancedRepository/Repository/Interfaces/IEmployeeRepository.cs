using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.ViewModels;
using System.Collections.Generic;

namespace AdvancedRepository.Repository.Interfaces
{
    public interface IEmployeeRepository: IBaseRepository<Employee>
    {
        List<EmployeeList> GetEmployeeList();
        List<EmployeeList> RecoverEmployeeList();
        string GetTitle(int id);
        int GetAge(int id);
        string FullName(int id);
        List<ManagerList> GetManagerList();
        EmplooyeeDetail GetEmployeeDetail(int id);

    }
}
