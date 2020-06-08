using System;
using System.ComponentModel.DataAnnotations;


namespace QuotingDojo.Models
{
    public class Quote
    {
        [Required]
        [MinLength(3)]
        [Display(Name = "Name")]
        public string username { get; set; }

        [Required]
        [MinLength(3)]
        [Display(Name = "Quote")]
        public string quote { get; set; }
    }
}
