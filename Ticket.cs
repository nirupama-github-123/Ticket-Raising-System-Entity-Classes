using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjectStructure
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }

        /// <summary>
        /// Subject of the ticket
        /// </summary>
        [Required(ErrorMessage = "Title is required")]
        [StringLength(50, ErrorMessage = "Title cannot exceed 50 characters")]
        public string Title { get; set; }

        [StringLength(250, ErrorMessage = "Description cannot exceed 250 characters")]
        public string Description { get; set; }

        [JsonIgnore]
        public Customer RaisedBy { get; set; }

        public TicketStatus Status { get; set; } = TicketStatus.Pending;

        [JsonIgnore]
        public SupportAgent? AssignedTo { get; set; }


        public Category? Category { get; set; }

        [Required(ErrorMessage = "CreatedDate is required")]
        public DateTime CreatedDate { get; set; }

        public DateTime? DueDate { get; set; }

        public Priority Priority { get; set; } = Priority.Low;

        public List<TicketHistory> TicketUpdates = new List<TicketHistory>();
    }
}
