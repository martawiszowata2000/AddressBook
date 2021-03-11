using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class Address
    {
        [Display(Name="Ulica")]
        [Required(ErrorMessage ="Pole obowiązkowe")]
        public string Street { set; get; }

        [Display(Name ="Kod pocztowy")]
        [StringLength(10, MinimumLength = 5), Required(ErrorMessage = "Pole obowiązkowe")]

        public string ZipCode { get; set; }

        [Display(Name ="Miasto")]
        [StringLength(40, MinimumLength = 3), Required(ErrorMessage = "Pole obowiązkowe")]

        public string City { get; set; }

        [Display(Name ="Numer")]
        [Required]

        public int Number { get; set; }
    }
}
