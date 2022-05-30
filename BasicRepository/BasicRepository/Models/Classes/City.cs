using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepository.Models.Classes
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public ICollection<Personnel> Personnels { get; set; }
    }
}
