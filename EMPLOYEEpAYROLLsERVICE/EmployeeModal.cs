using System;
using System.Collections.Generic;
using System.Text;

namespace EMPLOYEEpAYROLLsERVICE
{
    class EmployeeModal
    {
        //every variable name is same as shown in sql file
        public int Eemployee_id { get; set; }
        public string employee_name { get; set; }
        public int Employee_age { get; set; }
        public string Employee_address { get; set; }
        public string employee_gender { get; set; }
        public int employee_salary { get; set; }
        public DateTime ModifiedDate{ get; set; }
    }
}
