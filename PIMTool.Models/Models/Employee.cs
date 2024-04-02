﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIMTool.Models
{
    [Table("Employees")]
    public class Employee : BaseEntity
    {
        [Required]
        [StringLength(3)]
        public string Visa { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public virtual ICollection<ProjectEmployee> ProjectEmployees { get; set; }

        public Employee()
        {
            Visa = string.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthDate = DateTime.MinValue;
            ProjectEmployees = [];
        }
    }
}
