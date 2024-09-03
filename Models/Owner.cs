using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApiExample.Models;

// TODOS LOS CORCHETES SON DATA ANNOTATIONS
public class Owner
{
    [Key]
    public int Id { get; set; }

    [MinLength(5, ErrorMessage = "El nombre no puede tener menos de {1} caracteres.")]
    [MaxLength(125, ErrorMessage = "El nombre no puede tener más de {1} caracteres.")]
    public required string Name { get; set; }
    public required string LastName { get; set; }
    public required string IdNumber { get; set; }

    [Url(ErrorMessage = "La foto de perfil debe ser un url")]
    public required string ProfilePicture { get; set; }
    public required string Address { get; set; }

    [MinLength(5, ErrorMessage = "El número de teléfono no puede tener menos de {1} digitos.")]
    [MaxLength(25, ErrorMessage = "El número de teléfono no puede tener más de {1} digitos.")]
    [Phone(ErrorMessage = "El número de teléfono debe ser escrito en números.")]
    public required string NumberPhone { get; set; }

    [EmailAddress(ErrorMessage = "Verifica que hayas escrito el formato correcto para un correo electrónico")]
    [MinLength(5, ErrorMessage = "El correo electrónico no puede tener menos de {1} caracteres.")]
    [MaxLength(25, ErrorMessage = "El correo electrónico no puede tener más de {1} digitos.")]
    public required string Email { get; set; }


    // [NotMapped] Esta data anotation sirve para evitar que la base de datos cree la propiedad.

    [JsonIgnore] // Esto es para que no se genere un bucle a la hora de traer datos de la colección.
    public virtual ICollection<Vehicle> Vehicles { get; set; } // Colección de vehicles.
}
