using CoreDbFirst.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDbFirst.Models
{
    public class CategoryModel
    {
        public Category Category { get; set; }
        public string BtnVal { get; set; }
        public string BtnClass { get; set; }
        public string Header { get; set; }
    }
}
