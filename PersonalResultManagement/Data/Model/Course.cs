using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalResultManagement.Data.Model
{
    public class Course
    {
        public int Id;
        public string Title { get; set; }
        public string CodeCode { get; set; }
        public int Unit { get; set; }
        public int Score { get; set; }
    }
}
