using Domain;
using Domain.enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Data
{
    public static class SeedData
    {
        // Lisa 3 üritust ja kõigile üritustele lisa 3 osalejat.
        //
        // 1. Aenan Commodo:
        //   Mati Nurk
        //   Supersam OÜ
        //   Uku OÜ
        //
        // 2. Nunc lobortis
        // Lelle Mari
        // Mullam OÜ
        // Supersale OÜ
        //
        // 3. Integer nec null viate
        //  Tubli Malle
        //  Vegman klubi
        //  Supersale OÜ

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<WebAppContext>>()))
            {
                // look for any events
                if (context.Events.Any())
                {
                    return;
                }

                var events = new Event[]
                {
                    new Event
                    {
                        EventName = "Integer nec nulla vitae",
                        EventStartDate = new DateTime(2019, 6, 14),
                        EventLocation = "Regione equidem usu",
                        EventInformation = "Ad sit regione malorum, vel mucius eloquentiam an. Vix utinam animal appareat at. Cum eros mazim tibique et, intellegam assueverit duo no, mei ne velit incorrupte. Eum noster verear eu, ius diceret accommodare ea. Sed accusam nominavi id.",
                    },
                    new Event
                    {
                        EventName = "Aenean commodo",
                        EventStartDate = new DateTime(2018, 3, 18),
                        EventLocation = "Animal equidem usu",
                        EventInformation = "Ad sit regione malorum, vel mucius eloquentiam an. Vix utinam animal appareat at. Cum eros mazim tibique et, intellegam assueverit duo no, mei ne velit incorrupte. Eum noster verear eu, ius diceret accommodare ea. Sed accusam nominavi id.",

                    },
                    new Event
                    {
                        EventName = "Nunc lobortis metus eu massa viverra ultri iplacerat nibh",
                        EventStartDate = new DateTime(2016, 3, 3),
                        EventLocation = "Regione equidem usu",
                        EventInformation = "Ad sit regione malorum, vel mucius eloquentiam an. Vix utinam animal appareat at. Cum eros mazim tibique et, intellegam assueverit duo no, mei ne velit incorrupte. Eum noster verear eu, ius diceret accommodare ea. Sed accusam nominavi id.",

                    },
                };




                var people = new Person[]
                {
                    new Person{FirstName = "Mati", LastName = "Nurk", PersonalCode = Convert.ToInt32(3345432), PersonPaymentMethod = PaymentMethod.CreditCard, PersonRequests = "Exerci graeco necessitatibus te has, debet copiosae qualisque in vix, docendi nominavi pro ei. Id dictas euismod detraxit est, doming labore meliore per id. Ex meis audire ius, in quot."},
                    new Person{FirstName = "Lelle", LastName = "Mari", PersonalCode = Convert.ToInt32(275443), PersonPaymentMethod = PaymentMethod.Cash, PersonRequests = "Corpora probatus consequat in pro, mea tantas quodsi mollis ut. Ponderum intellegebat voluptatibus"},
                    new Person{FirstName = "Tubli", LastName = "Kalle", PersonalCode = Convert.ToInt32(3875434), PersonPaymentMethod = PaymentMethod.CreditCard, PersonRequests = "Corpora probatus consequat in pro, mea tantas quodsi mollis ut. Ponderum intellegebat voluptatibus"}

                };

              

                var companies = new Company[]
                {
                    new Company{CompanyName= "Supersam OÜ", NumberOfParticipants = 5, CompanyPaymentMehtod = PaymentMethod.CreditCard, CompanyRegistrationNr = Convert.ToInt32(335432) ,CompanyRequests = "Loren Ipsur Lorem Ipur Lorem Ipsur"},
                    new Company{CompanyName= "Uku OÜ", NumberOfParticipants = 8, CompanyPaymentMehtod = PaymentMethod.CreditCard, CompanyRegistrationNr = Convert.ToInt32(334432), CompanyRequests = "Loren Ipsur Lorem Ipur Lorem Ipsur"},
                    new Company{CompanyName= "Nullam OÜ", NumberOfParticipants = 5, CompanyPaymentMehtod = PaymentMethod.CreditCard, CompanyRegistrationNr = Convert.ToInt32(35432),CompanyRequests = "Loren Ipsur Lorem Ipur Lorem Ipsur"},
                    new Company{CompanyName= "Supersale OÜ", NumberOfParticipants = 5, CompanyPaymentMehtod = PaymentMethod.CreditCard, CompanyRegistrationNr = Convert.ToInt32(3432432),CompanyRequests = "Loren Ipsur Lorem Ipur Lorem Ipsur"},
                    new Company{CompanyName= "Vegman klubi", NumberOfParticipants = 2, CompanyPaymentMehtod = PaymentMethod.CreditCard, CompanyRegistrationNr = Convert.ToInt32(3134432), CompanyRequests = "Loren Ipsur Lorem Ipur Lorem Ipsur"},
                    new Company{CompanyName= "DoubleCash AS", NumberOfParticipants = 6, CompanyPaymentMehtod = PaymentMethod.CreditCard,CompanyRegistrationNr = Convert.ToInt32(3321432), CompanyRequests = "Loren Ipsur Lorem Ipur Lorem Ipsur"}
                };

               






               

                var participants = new Participant[]
                {
                    new Participant{EventId = 1, PersonId = 1, CompanyId = null, Type = ParticipantType.Person},
                    new Participant{EventId = 1, PersonId = null, CompanyId = 1, Type = ParticipantType.Company},
                    new Participant{EventId = 1, PersonId = null, CompanyId = 2, Type = ParticipantType.Company},
                    new Participant{EventId = 2, PersonId = 2, CompanyId = null, Type = ParticipantType.Person},
                    new Participant{EventId = 2, PersonId = null, CompanyId = 3, Type = ParticipantType.Company},
                    new Participant{EventId = 2, PersonId = null, CompanyId = 4, Type = ParticipantType.Company},
                    new Participant{EventId = 3, PersonId = 3, CompanyId = null, Type = ParticipantType.Person},
                    new Participant{EventId = 3, PersonId = null, CompanyId = 5, Type = ParticipantType.Company},
                    new Participant{EventId = 3, PersonId = null, CompanyId = 6, Type = ParticipantType.Company}

                };

               


                foreach (Event e in events)
                {
                    context.Events.Add(e);
                }

                context.SaveChanges();

                foreach (Person p in people)
                {
                    context.People.Add(p);
                }

                context.SaveChanges();

                foreach (Participant p in participants)
                {
                    context.Participants.Add(p);
                }
                //context.SaveChanges();

                foreach(Company c in companies)
                {
                    context.Companies.Add(c);
                }

                context.SaveChanges();

            }
        }
    }
}
