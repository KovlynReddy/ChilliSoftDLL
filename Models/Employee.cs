using ChilliSoftDLL.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChilliSoftDLL.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string EmployeeStatus { get; set; }
        public string EmployeePosition { get; set; }
        public EmployeePositions ep { get; set; }
    }
}
