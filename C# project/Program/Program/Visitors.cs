using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Visitors
    {
    }

    public class Visitor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime TicketDate { get; set; }

        public Visitor() { }

        public Visitor(int id, string name, string email, DateTime ticketDate)
        {
            Id = id;
            Name = name;
            Email = email;
            TicketDate = ticketDate;
        }
    }
}
