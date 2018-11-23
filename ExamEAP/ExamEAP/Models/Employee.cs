using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamEAP.Models
{
    public class Employee
    {
        public Employee()
        {
            this.CreatedAt = DateTime.Now;
            this.UpdatedAt = DateTime.Now;
            this.Status = EmployeeStatus.Activated;
        }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public long Salary { get; set; }
        public string Department { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public EmployeeStatus Status { get; set; }
    }

    public enum EmployeeStatus
    {
        Activated = 1,
        Deactivated = 0
    }
}