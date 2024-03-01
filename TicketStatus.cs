using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStructure
{
    public enum TicketStatus
    {
        Unassigned = 1,
        Pending,
        InProgress,
        OnHold,
        AwaitingResponse,
        Resolved
    }
}
