using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalManagement.Test.Exceptions
{
   public class SearchAppoinmentException:Exception
   {

        public string Messages = "Appoinment Not Found";

        public SearchAppoinmentException(string message)
        {
                Messages = message;
        }
        
    }
}
