using HospitalManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Businesslayer.Interaface
{
   public  interface IOfficeManagerService
   {
        bool Registerpatient(Patient patient);
        Patient SearchPatient(int Patientid);
        bool ScheduleAppoinment(int staffId);
        Appointment SearchAppoinment(int StaffId);

        Appointment GetAppointment(int StaffId);
   }
}
