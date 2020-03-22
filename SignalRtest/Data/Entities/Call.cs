using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRtest.Data.Entities
{
    public class Call
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Problem { get; set; }
        public bool Answered { get; set; } = false;
        public DateTime CallTime { get; set; } = DateTime.Now;
        public DateTime AnswerTime { get; set; } = DateTime.MinValue;
    }
}
