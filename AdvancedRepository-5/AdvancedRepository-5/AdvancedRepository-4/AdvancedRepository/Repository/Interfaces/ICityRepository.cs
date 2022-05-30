using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using System.Collections.Generic;

namespace AdvancedRepository.Repository.Interfaces
{
    public interface ICityRepository: IBaseRepository<City>
    {
        List<CityList> GetCityList();
        List<CityList> RecoverCityList();
    }
}
