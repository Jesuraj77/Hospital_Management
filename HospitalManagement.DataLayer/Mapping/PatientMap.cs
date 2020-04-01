using FluentNHibernate.Mapping;
using HospitalManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.DataLayer.Mapping
{
    public class PatientMap : ClassMap<Patient>
    {
        public PatientMap()
        {
            Id(x => x.PatientId);

            Map(x => x.PatientName);

            Map(x => x.PatientHeight);
            Map(x => x.PatientWeight);
            Map(x => x.PatientGender);
            Map(x => x.PatientContectNumber);
            Map(x => x.PatientEmerContectNumber);
            Map(x => x.PatientDOR);
            Map(x => x.PatientHasInsurence);
            Map(x => x.PatientPolicyNumber);
            Map(x => x.PatientInsurenceName);
            Table("patient");

        }
    }
}
