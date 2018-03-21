using Domain.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class Person 
    {
        public int PersonId { get; set; }

        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }

        public int PersonalCode { get; set; }

        public PaymentMethod PersonPaymentMethod { get; set; }

        [MaxLength(1500)]
        public string PersonRequests { get; set; }

        [ForeignKey("ParticipantId")]
        public int ParticipantId { get; set; }
        //public Participant Participant { get; set; }


    }
}
