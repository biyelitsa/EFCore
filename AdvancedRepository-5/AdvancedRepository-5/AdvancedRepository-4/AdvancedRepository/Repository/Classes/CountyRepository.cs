using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models;
using AdvancedRepository.Models.Classes;
using AdvancedRepository.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedRepository.Repository.Classes
{
    public class CountyRepository: BaseRepository<County>, ICountyRepository
    {
        public CountyRepository(CompanyContext db): base(db)
        {

        }

        public List<CountyList> GetCountyList()
        {
            return Set().Select(x => new CountyList
            {
                CountyId = x.Id,
                CountyName = x.CountyName,
                Deleted=x.Deleted
                
            }).Where(x=>x.Deleted==false).ToList();
        }

        public List<CountyList> ListByCityId(int id)
        {
            return Set().Select(x => new CountyList
            {
                CountyId = x.Id,
                CountyName = x.CountyName,
                CityId = x.CityId
            }).Where(x => x.CityId == id).ToList();
        }

        public List<CountyList> RecoverCountyList()
        {
            return Set().Select(x => new CountyList
            {
                CountyId = x.Id,
                CountyName = x.CountyName,
                Deleted = x.Deleted

            }).Where(x => x.Deleted == true).ToList();
        }
    }
}
