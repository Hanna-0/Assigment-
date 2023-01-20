using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreateDeleteAPI.Model
{
    public class DepartementModel
    {
        [Key]
        public int DepartmentID { get; set; }
        public string Department { get; set; }
      
    }
}
