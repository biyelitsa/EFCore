using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepositorySoftDelete.Models.Classes
{
    public class Personnel:Base
    {
        public string PersonnelName { get; set; }
        public string PersonnelSurname { get; set; }
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
    }
}
