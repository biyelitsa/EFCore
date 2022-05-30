using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCore.Models.Data.Classes
{
    public class City
    {
        public City()
        {
            this.Personnels = new HashSet<Personnel>();
        }
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string Picture { get; set; }
        public virtual ICollection<Personnel> Personnels { get; set; }
    }
}
