using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Entities
{
    public class Patient
    {
        public virtual int PatientId { get; set; }
        public virtual string PatientName { get; set; }
        public virtual float PatientHeight { get; set; }
        public virtual float PatientWeight { get; set; }
        public virtual string PatientGender { get; set; }
        public virtual string PatientContectNumber { get; set; }
        public virtual string PatientEmerContectNumber { get; set; }
        public virtual DateTime PatientDOR { get; set; }
        public virtual bool PatientHasInsurence { get; set; }
        public virtual string PatientPolicyNumber { get; set; }
        public virtual string PatientInsurenceName { get; set; }
        public virtual int DId { get; set; }
        public virtual int MId { get; set; }
    }
}
