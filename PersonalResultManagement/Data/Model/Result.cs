using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalResultManagement.Data.Model
{
    public class Result
    {
        public int Id { get; set; }
        public int CouseId { get; set; }
        public int StudentId { get; set; }
        public int Scores { get; set; }
    }
}
