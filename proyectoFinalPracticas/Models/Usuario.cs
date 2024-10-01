using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Xunit;
using Xunit.Sdk;

namespace proyectoFinalPracticas.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    [Required (ErrorMessage = "Este campo es requerido")]
    public string? Email { get; set; }

    
    [Display (Name = "Contraseña")]
    [DataType(DataType.Password)]
    public string? Clave { get; set; }

    [Display(Name = "Repetir Contraseña")]
    [DataType(DataType.Password)]
    [NotMapped]
    [Compare("Clave", ErrorMessage = "Las constraseñas no coinciden")]
    public string? ReClave { get; set; }

    //comentario de Agus
    //comentario agus dos
}
