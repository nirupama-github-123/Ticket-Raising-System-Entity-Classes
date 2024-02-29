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
    internal class Ticket
{
    [Key]
    public int TicketId { get; set; }

    [Required(ErrorMessage = "Title is required")]
    [StringLength(50, ErrorMessage = "Title cannot exceed 50 characters")]
    public string Title { get; set; }

    [StringLength(250, ErrorMessage = "Description cannot exceed 250 characters")]
    public string Description { get; set; }

    [ForeignKey("Customer")]
    [JsonIgnore]
    public Customer RaisedBy { get; set; }

    public TicketStatus Status { get; set; } = TicketStatus.Pending;

    [JsonIgnore]
    public ServiceAgent AssignedTo { get; set; }

    [StringLength(50)]
    public string Category { get; set; }

    [Required(ErrorMessage = "CreatedDate is required")]
    public DateTime CreatedDate { get; set; }
}
}
