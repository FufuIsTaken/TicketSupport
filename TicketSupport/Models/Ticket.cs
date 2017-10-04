using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TicketSupport.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        [Required]
        public string Customer { get; set; }
        [Required]
        public string Application { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }

    }
}