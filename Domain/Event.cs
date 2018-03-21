using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    public class Event
    {
        public int  EventId { get; set; }

        [MaxLength(100)]
        [Display(Name ="Ürituse nimi")]
        public string EventName { get; set; }

        [Display(Name = "Toimumisaeg")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EventStartDate { get; set; }

        [MaxLength(100)]
        [Display(Name = "Koht")]
        public string EventLocation { get; set; }

        [MaxLength(1000)]
        [Display(Name = "Lisainfo")]
        public string EventInformation { get; set; }

        public bool HasEventPassed
        {
            get
            {
                if (EventStartDate > DateTime.Now) return false;
                else return true;
            }
        }
        public int NumberOfTotalParticipants { get; set; }

        public virtual List<Participant> Participants { get; set; } = new List<Participant>();
    }
}
