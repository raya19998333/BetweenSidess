using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetweenSides1.Models
{
    public class Lawyer
    {
        [Key]
        public int LawyerId { get; set; }
        public string? Name { get; set; }
        public string? LicenseNumber { get; set; }
        public string? Specialization { get; set; }

        public ICollection<Defendant> Defendants { get; set; } = new List<Defendant>();
    }
}
