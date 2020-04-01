using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Entities
{
  public  class Appointment
    {
        public virtual DateTime AppointmentDate { get; set; }
        public virtual string DepartmentName { get; set; }
        public virtual string StaffName  { get; set; }
        public virtual DateTime AppointmentTime { get; set; }
        public virtual int StaffId { get; set; }
        public virtual int  PatientId { get; set; }
    }
}
