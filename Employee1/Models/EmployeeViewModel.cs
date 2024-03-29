using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employee1.Models
{
    public class EmployeeViewModel
    {
        [DisplayName("ID")]
        public int EmployeeID { get; set; }

        [DisplayName("Name")]
        
        public string Name { get; set; }

        [DisplayName("Address")]
        public string Address { get; set; }

        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Contact No.")]
        public string ContactNo { get; set; }

        [DisplayName("Qualification")]
        public string Qualification { get; set; }

        [DisplayName("Previous Company Name")]
        public string PreviousCompanyName { get; set; }

        [DisplayName("Status")]
        public bool Status { get; set; }
        public String Action { get; set; }
    }
}
