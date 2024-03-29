using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employee1.Models.DBEntities
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }
        [Column(TypeName ="varchar(50)")]
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Column(TypeName ="varchar(20)")]

        public string ContactNo { get; set; }
        [Column(TypeName ="varchar(20)")]
        public string Qualification { get; set; }
        public string PreviousCompanyName { get; set; }   
        //public string Email { get; set; }

        public bool Status { get; set; }
        public string Action { get; set; }
    }
}
