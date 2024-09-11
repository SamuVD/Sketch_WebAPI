using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ApiExample.Models;

// TODOS LOS CORCHETES SON DATA ANNOTATIONS
[Table("owners")]
public class Owner
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [Required]
    [MaxLength(100, ErrorMessage = "El nombre no puede tener más de {1} caracteres.")]
    public string Name { get; set; }

    [Column("last_name")]
    [Required]
    [MaxLength(150, ErrorMessage = "El apellido no puede tener más de {1} caracteres.")]
    public string LastName { get; set; }

    // LUEGO IMPLEMENTAMOS UNA BUENA VALIDACIÓN PARA EL NÚMERO DE IDENTIFICACIÓN.
    // [Column("id_number")]
    // [Required]
    // [RegularExpression("")]
    // public string IdNumber { get; set; }

    [Column("profile_picture")]
    [Url(ErrorMessage = "La foto de perfil debe ser un url")]
    public string ProfilePicture { get; set; }

    [Column("number_phone")]
    [Required]
    [MinLength(7, ErrorMessage = "El número de teléfono no puede tener menos de {1} digitos.")]
    [MaxLength(13, ErrorMessage = "El número de teléfono no puede tener más de {1} digitos.")]
    [Phone(ErrorMessage = "El número de teléfono debe ser escrito en números.")]
    public string NumberPhone { get; set; }

    [Column("email")]
    [Required]
    [EmailAddress(ErrorMessage = "Verifica que hayas escrito el formato correcto para un correo electrónico")]
    [MinLength(5, ErrorMessage = "El correo electrónico no puede tener menos de {1} caracteres.")]
    [MaxLength(255, ErrorMessage = "El correo electrónico no puede tener más de {1} digitos.")]
    public string Email { get; set; }


    // [NotMapped] Esta data anotation sirve para evitar que la base de datos cree la propiedad.

    //[JsonIgnore] // Esto es para que no se genere un bucle a la hora de traer datos de la colección.
    // public virtual ICollection<Vehicle> Vehicles { get; set; } // Colección de vehicles.
}
