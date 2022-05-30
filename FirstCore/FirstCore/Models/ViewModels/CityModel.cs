using FirstCore.Models.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCore.Models.ViewModels
{
    public class CityModel
    {
        //public CityModel()
        //{
        //    City = new City();
        //}
        public string Heading { get; set; }
        public string BtnClass { get; set; }
        public string BtnVal { get; set; }
        public City City { get; set; }
    }
}
