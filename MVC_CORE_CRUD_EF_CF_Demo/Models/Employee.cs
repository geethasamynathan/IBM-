using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace MVC_CORE_CRUD_EF_CF_Demo.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        
        [Column(TypeName ="varchar(50)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Designation { get; set; }


        [Column(TypeName = "varchar(100)")]
        [DisplayName("Office Location")]
        public string Location { get; set; }
    }
}
