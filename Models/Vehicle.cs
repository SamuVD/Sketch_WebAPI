using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExample.Models;

public class Vehicle
{
    [Key]
    public int Id { get; set; }
    public required string Brand { get; set; }
    public required string Model { get; set; }
    public required int Year { get; set; }
    public required string Color { get; set; }
    public required string TypeOfVehicle { get; set; }

    // Referencia a la clase Propietario
    public required int OwnerId { get; set; }

    // Referencia de la forein Key de la clase Propietario. Haciendo relación de uno a muchos. (Enlaces foraneos)
    // [ForeignKey("OwnerId")]
    public Owner Owner { get; set; }
}
