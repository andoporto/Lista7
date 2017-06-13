using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Lista7.Models;

namespace Lista7.Models
{


    [MetadataType(typeof(EstudianteMetaData))]
    public partial class Estudiante
    {
    }
    

    public enum Genero
    {
        Masculino,
        Femenino
    }
}