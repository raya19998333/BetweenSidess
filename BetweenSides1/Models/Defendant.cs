using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetweenSides1.Models
{
    public class Defendant
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? NationalID { get; set; }
        public string? CaseId { get; set; }   // ✅ Nullable
        public string? Status { get; set; }

        

        [ForeignKey(nameof(Lawyer))]
        public int LawyerId { get; set; }
        public Lawyer lawyer { get; set; }
    }
}
