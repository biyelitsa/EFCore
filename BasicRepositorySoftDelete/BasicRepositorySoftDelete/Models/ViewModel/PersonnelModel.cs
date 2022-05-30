using BasicRepositorySoftDelete.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepositorySoftDelete.Models.ViewModel
{
    public class PersonnelModel
    {
        public Personnel Personnel { get; set; }
        public string Header { get; set; }
        public string BtnClass { get; set; }
        public string BtnVal { get; set; }
    }
}
