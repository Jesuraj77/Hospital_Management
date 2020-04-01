using HospitalManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HospitalManagement.Test.TestCases
{
  public  class BoundaryTest
    {

        [Fact]
        public void BoundaryTest_ForPassword_Length()
        {
            Staff staff = new Staff()
            {
                Password = "111"
            };
            var MinLength = 8;
            var MaxLength = 25;

            //Action
            var actualLength = staff.Password.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ForUserName_Length()
        {

            Staff staff = new Staff()
            {
                StaffName = "111"
            };
            //Arrange
            var MinLength = 0;
            var MaxLength = 50;

            //Action
            var actualLength = staff.StaffName.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }


        [Fact]
        public void BoundaryTest_PatientContectNumber_Length()
        {
            Patient staff = new Patient()
            {
                PatientContectNumber = "1111111111"
            };
            var MinLength = 10;
            var MaxLength = 10;

            //Action
            var actualLength = staff.PatientContectNumber.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
    }
}
