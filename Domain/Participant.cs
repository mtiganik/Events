using Domain.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    // Firma või eraisik
    public class Participant
    {
        public int ParticipantId { get; set; }

        public int EventId { get; set; }
        public virtual Event Event { get; set; }
         

        public ParticipantType Type { get; set; } 

        // kui on firma, siis see on NULL
        public int? PersonId { get; set; }
        public virtual Person Person { get; set; }


        // kui on eraisik, siis see on NULL
        public int? CompanyId { get; set; }
        public virtual Company Company { get; set; }


    }
}
