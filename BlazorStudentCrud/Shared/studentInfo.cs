using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace BlazorStudentCrud.Shared
{
    public class studentInfo
    {
        public int stdId { get; set; }
        public String studentName { get; set; }
        public String course { get; set; }
        public String year { get; set; }
    }
}
