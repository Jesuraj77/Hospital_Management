using HospitalManagement.Businesslayer.Services;
using HospitalManagement.DataLayer.NHibernateConfiguration;
using HospitalManagement.Entities;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HospitalManagement.Test.TestCases
{
    public class FunctionalTest
    {
        private readonly NurseServices _Nurseservices;
        private readonly OfficeManagerService _OfficeManagerservice;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public FunctionalTest()
        {
            _Nurseservices = new NurseServices(_session);
            _OfficeManagerservice = new OfficeManagerService(_session);
        }

        [Fact]
        public void Test_for_DiagnosisPatient()
        {
            Patient patient = new Patient()
            {
                PatientId = 1
            };

            var result = _Nurseservices.DiagnosisPatient(patient.PatientId);
            Assert.True(result);
        }


        [Fact]
        public void Test_for_PreviousPrescriptionsofPatient()
        {
            Patient patient = new Patient()
            {
                PatientId = 2,

            };

            var result = _Nurseservices.PreviousPrescriptionsofPatient(patient.PatientId);
            var getpatient = _Nurseservices.GetPatient(patient.PatientId);

            Assert.Equal(getpatient, result);


        }

        [Fact]
        public void Test_for_SearchAppoinment()
        {
            Staff staff = new Staff()
            {
                StaffId = 1
            };

            Appointment appointment = new Appointment()
            {
                AppointmentDate = DateTime.Now
            };

            var result = _Nurseservices.SearchAppoinment(staff.StaffId, appointment.AppointmentDate);
            var GetAppoinment = _Nurseservices.GetAppointment(staff.StaffId, appointment.AppointmentDate);

            Assert.Equal(GetAppoinment, result);

        }

        [Fact]
        public void Test_for_SendthePrescriptions()
        {
            Medicine medicine = new Medicine()
            {
                MId = 1,
                MName = "aa",
                Dose = "aa",
                PresId = 1,

            };

            var result = _Nurseservices.SendthePrescriptions(medicine);
            Assert.True(result);
        }

        [Fact]
        public void Test_for_Registerpatient()
        {
            Patient patient = new Patient()
            {
                PatientId = 1,
                PatientName = "aaa",
                PatientHeight = 11,
                PatientWeight = 11,
                PatientContectNumber = "11111111",
                PatientEmerContectNumber = "111222222",
                PatientDOR = DateTime.Now,
                PatientGender = "f",
                PatientHasInsurence = true,
                PatientInsurenceName = "aa",
                PatientPolicyNumber = "111"

            };

            var result = _OfficeManagerservice.Registerpatient(patient);
            Assert.True(result);
        }

        [Fact]
        public void Test_for_SearchPatient()
        {
            Patient patient = new Patient()
            {
                PatientId = 2,

            };

            var result = _OfficeManagerservice.SearchPatient(patient.PatientId);
            var getpatient = _Nurseservices.GetPatient(patient.PatientId);

            Assert.Equal(getpatient, result);

        }

        [Fact]
        public void Test_for_ScheduleAppoinment()
        {
            Staff staff = new Staff()
            {
                StaffId = 1
            };

            var result = _OfficeManagerservice.ScheduleAppoinment(staff.StaffId);

            Assert.True(result);

        }

        [Fact]
        public void Test_for_AppoinmentSearch()
        {
            Staff staff = new Staff()
            {
                StaffId = 1
            };

            

            var result = _OfficeManagerservice.SearchAppoinment(staff.StaffId);
            var GetAppoinment = _OfficeManagerservice.GetAppointment(staff.StaffId);

            Assert.Equal(GetAppoinment, result);

        }

    }
}
