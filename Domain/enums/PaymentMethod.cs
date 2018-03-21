using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.enums
{
    public enum PaymentMethod
    {
        [Display(Name = "Sularaha")]
        Cash,

        [Display(Name = "Pangakaart")]
        CreditCard
    }
}
