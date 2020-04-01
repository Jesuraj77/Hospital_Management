using HospitalManagement.Businesslayer.Services;
using HospitalManagement.DataLayer.NHibernateConfiguration;
using HospitalManagement.Entities;
using HospitalManagement.Test.Exceptions;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HospitalManagement.Test.TestCases
{
   public class ExceptionTest
    {

        private readonly NurseServices _Nurseservices;
        private readonly OfficeManagerService _OfficeManagerservice;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public ExceptionTest()
        {
            _Nurseservices = new NurseServices(_session);
            _OfficeManagerservice = new OfficeManagerService(_session);
        }

        [Fact]
        public void ExceptionTestFor_AppoinmentNotFound()
        {
            Staff staff = new Staff()
            {
              StaffId=1
            };

            //Assert
            var ex = Assert.Throws<SearchAppoinmentException>(() => _OfficeManagerservice.SearchAppoinment(staff.StaffId)) ;
            Assert.Equal("Appoinment Not Found ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_PatientNotFound()
        {
            Patient patient = new Patient()
            {
                PatientId = 1,
            

            };

            var ex = Assert.Throws<PatientNotFoundException>(() => _OfficeManagerservice.SearchPatient(patient.PatientId));
            Assert.Equal("Patient Not Found ", ex.Messages);

        }

        [Fact]
        public void ExceptionTestFor_SearchAppoinmentNotFound()
        {
            Staff staff = new Staff()
            {
                StaffId = 1
            };

            Appointment appointment = new Appointment()
            {
                AppointmentDate = DateTime.Now
            };


            //Assert
            var ex = Assert.Throws<SearchAppoinmentException>(() => _Nurseservices.SearchAppoinment(staff.StaffId,appointment.AppointmentDate));
            Assert.Equal("Appoinment Not Found ", ex.Messages);
        }


    }
}
