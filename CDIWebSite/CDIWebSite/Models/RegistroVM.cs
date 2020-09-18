using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CDIWebSite.Models
{
    public class RegistroVM
    {
        [Required(ErrorMessage = "¡Por favor, danos un nombre!")]
        public string Name { get; set; }

        public string Lastname { get; set; }

        public DateTime BornDate { get; set; }

        public int Age { get; set; }

        public char Gender { get; set; }

        [Required(ErrorMessage = "¡Por favor, brindanos este dato!")]
        public string Email { get; set; }

        //public string Name { get; set; }

    }
}