using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStructure
{
    public class TicketHistory
    {
        [Key]
        public int TicketHistoryId { get; set; }

        public Customer? UpdatedByCustomer { get; set; }

        public SupportAgent? UpdatedBySupportAgent { get; set; }

        [Required]
        public DateTime UpdatedDate { get; set; }
    }
}
