using System;
using System.ComponentModel.DataAnnotations;

namespace Elections.Dtos
{
    public class ElectionsUpdateDto
    {
       public string PartyName { get; set; }

       public string PartyAbbr { get; set; }

       public string Leader { get; set; }

       public string RegistrationDate { get; set; } 
    }
}
