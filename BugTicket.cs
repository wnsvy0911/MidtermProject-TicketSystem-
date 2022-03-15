using System.Collections.Generic;

namespace TicketingSystem
{
    class BugTicket: Ticket
    {

        public string severity {get; set;}
         public BugTicket (
            int ticketId,
            string summary,
            string status,
            string priority,
            string submitter,
            string assigned,
            List<string> watching,
            string severity) : base (ticketId, summary, status, priority, submitter, assigned, watching)
        {
           this.severity = severity;
        }
    }
} 