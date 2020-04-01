using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Entities
{
    public class Diagnosis
    {
        public virtual int DId { get; set; }
        public virtual DateTime DDate { get; set; }
        public virtual string Problem { get; set; }
        public virtual string diagnosis { get; set; }

    }
}
