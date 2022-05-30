using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using System.Collections.Generic;

namespace AdvancedRepository.Repository.Interfaces
{
    public interface ICountyRepository: IBaseRepository<County>
    {
        List<CountyList> GetCountyList();
        List<CountyList> RecoverCountyList();
        List<CountyList> ListByCityId(int id);
    }
}
