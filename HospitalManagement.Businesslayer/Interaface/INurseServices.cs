using HospitalManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Businesslayer.Interaface
{
   public interface INurseServices
   {
        Patient ViewPatientMedicalSummery(int PatientId);
        Patient PreviousPrescriptionsofPatient(int PatientId);
        bool SendthePrescriptions(Medicine medicine);
        Appointment SearchAppoinment(int StaffId, DateTime AppointmentTime);
        bool DiagnosisPatient(int PatientId);
        Patient GetPatient(int PatientId);
        Appointment GetAppointment(int stafId, DateTime AppointmentTime);

   }
}
