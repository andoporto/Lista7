using Lista7.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lista7.Models
{
    public class EstudianteMetaData
    {
        public int EstudianteId { get; set; }
        [Required]
        [StringLength(50)]
        public string EstudianteNombre { get; set; }
        [Required]
        public Genero EstudianteGenero { get; set; }
    }
}