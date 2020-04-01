using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Entities
{
    public class Medicine
    {
        public virtual int MId { get; set; }
        public virtual string MName { get; set; }
        public virtual string Dose { get; set; }
        public virtual int  PresId { get; set; }
    }
}
