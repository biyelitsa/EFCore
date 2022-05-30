using FirstCore.Models.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCore.Models.ViewModels
{
    public class PersonnelModel
    {
        public PersonnelModel()
        {
            
        }

        public Personnel Personnel { get; set; }
        public string Heading { get; set; }
        public string BtnClass { get; set; }
        public string BtnVal { get; set; }
        public List<City> CityList { get; set; }
    }
}
