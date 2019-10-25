using System;
using System.ComponentModel.DataAnnotations;

namespace tallerPuntoNet.Models
{
    public class Contacto
    {
        [Required]
        [MaxLength(100)]
       public string nombre {get ; set;}

       [Required]
        [MaxLength(100)]
       public string apellido {get ; set;}

       [Required]
        [DataType(DataType.PhoneNumber)]
       public string telefono {get ; set;}

       [Required]
        [EmailAddress]
       public string email {get ; set;}

        [Required]
        [MaxLength(500)]
       public string mensaje {get;set;}


    }
}
