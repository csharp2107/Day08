using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreMariaDbExample
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }

        // navigation property
        public virtual Department Department { get; set; }
        public virtual EmployeeAddress EmployeeAddress { get; set; }
    }

    class EmployeeAddress
    {
        public int EmployeeAddressID { get; set; }
        public string Address { get; set; }
        //
        public virtual Employee Employee { get; set; }
    }

    class Department
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        // navigation property - returning the list  of Employees
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
