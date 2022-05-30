using System;
using System.Collections.Generic;

#nullable disable

namespace CoreDbFirst.Models.Data
{
    public partial class EmpMan
    {
        public int EmployeeId { get; set; }
        public string Employee { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public string Manager { get; set; }
    }
}
