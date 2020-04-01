using HospitalManagement.Businesslayer.Interaface;
using HospitalManagement.DataLayer.NHibernateConfiguration;
using HospitalManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Businesslayer.Services
{
    public class NurseServices : INurseServices
    {

        private readonly IMapperSession _session;

        public NurseServices(IMapperSession session)
        {
            _session = session;
        }

        public bool DiagnosisPatient(int PatientId)
        {
            return true;
        }

        public Appointment GetAppointment(int stafId, DateTime AppointmentTime)
        {
            Appointment appointment = new Appointment();
            return appointment;
        }

        public Patient GetPatient(int PatientId)
        {
            Patient patient = new Patient();
            return patient;
        }

        public Patient PreviousPrescriptionsofPatient(int PatientId)
        {
            Patient patient = new Patient();
            return patient;
        }

        public Appointment SearchAppoinment(int StaffId, DateTime AppointmentTime)
        {
            Appointment appointment = new Appointment();
            return appointment;
        }

        public bool SendthePrescriptions(Medicine medicine)
        {
            return true;
        }

        public Patient ViewPatientMedicalSummery(int PatientId)
        {
            Patient patient = new Patient();
            return patient;
        }
    }
}
