using HospitalManagement.Businesslayer.Interaface;
using HospitalManagement.DataLayer.NHibernateConfiguration;
using HospitalManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Businesslayer.Services
{
    public class OfficeManagerService : IOfficeManagerService
    {

        private readonly IMapperSession _session;

        public OfficeManagerService(IMapperSession session)
        {
            _session = session;
        }

        public Appointment GetAppointment(int StaffId)
        {
            Appointment appointment = new Appointment();
            return appointment;
        }

        public bool Registerpatient(Patient patient)
        {
            return true;
        }

        public bool ScheduleAppoinment(int staffId)
        {
           
            return true;
        }

        public Appointment SearchAppoinment(int StaffId)
        {
            Appointment appointment = new Appointment();
            return appointment; 
        }

        public Patient SearchPatient(int Patientid)
        {
            Patient patient = new Patient();
            return patient;
        }
    }
}
