using System.ComponentModel.DataAnnotations;

namespace Elections.Dtos
{
    public class ElectionsCreateDto
    {
        [Required]
        public string PartyName { get; set; }
        [Required]
        public string PartyAbbr { get; set; }
        [Required]
       public string Leader { get; set; } 
       [Required]        
       public string RegistrationDate { get; set; } 
    }
}