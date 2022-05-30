using BasicRepository.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepository.Models.ViewModel
{
    public class PersonnelModel
    {
        public Personnel Personnel { get; set; }
        public string Header { get; set; }
        public string BtnClass { get; set; }
        public string BtnVal { get; set; }
    }
}
