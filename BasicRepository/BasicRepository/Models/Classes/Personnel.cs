using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepository.Models.Classes
{
    public class Personnel
    {
        [Key]
        public int PersonnelId { get; set; }
        public int CityId { get; set; }
        public string PersonnelName{ get; set; }
        public string PersonnelSurname { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }
    }
}
