using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorAppVS.Shared.Entities
{
    public class Gender
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")] 
        public string Name { get; set; }
    }
}
