using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Test.Exceptions
{
    public class PatientNotFoundException : Exception
    {
        public string Messages = "Patient Not Found";

        public PatientNotFoundException(string message)
        {
            Messages = message;
        }
    }
}