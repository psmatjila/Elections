using System;
using System.ComponentModel.DataAnnotations;

namespace Elections
{
    public class IecParties
    {
        [Required]
        [Key]
       public string PartyName { get; set; }
       [Required]
       public string PartyAbbr { get; set; }
       [Required]
       public string Leader { get; set; }
       [Required]
       public string RegistrationDate { get; set; }
    }
}
