using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Entities
{
   public class Staff
    {
      
        public virtual int StaffId { get; set; }
        public virtual string StaffName { get; set; }
        public virtual  string Password { get; set; }
        public virtual int  DeptId { get; set; }
    }
}
