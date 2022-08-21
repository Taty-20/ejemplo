using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ejemplo.Models;

namespace ejemplo.Models
{
    public class Contacto
    {
        [Display (Name = "Nombre Completo")]
        public string? Name {get;set;}
        [EmailAddress]
        [Display (Name = "Correo")]
        public string? Email {get;set;}
        [Phone]
        [Display (Name = "Telefono")]
        public string? Phone {get;set;}
        [MinLength(5)]
        [MaxLength(1024)]
        
        [Display (Name = "Descripcion")]
        public string? Description {get;set;}
        
    }
}