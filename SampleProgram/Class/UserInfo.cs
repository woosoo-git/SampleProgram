using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProgram.Class
{
    public class UserInfo
    {
        public long Seq { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Team { get; set; }
        public bool IsIncumbent { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime? LeaveDate { get; set; }
    }
}
