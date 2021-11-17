using System;
using System.ComponentModel.DataAnnotations;

namespace Elections.Dtos
{
    public class ElectionsReadDto
    {
       public string PartyName { get; set; }

       public string PartyAbbr { get; set; }

       public string Leader { get; set; }
       
    }
}
