using Domain.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class Company 
    {
        public int CompanyId { get; set; }

        [MaxLength(100)]
        public string CompanyName { get; set; }

        public int CompanyRegistrationNr { get; set; }

        [Display(Name = "Makseviis")]
        public PaymentMethod CompanyPaymentMehtod { get; set; }

        public int NumberOfParticipants { get; set; }

        [MaxLength(5000)]
        public string CompanyRequests { get; set; }

        [ForeignKey("ParticipantId")]
        public int ParticipantId { get; set; }
        //public virtual Participant Participant { get; set; }
    }
}
