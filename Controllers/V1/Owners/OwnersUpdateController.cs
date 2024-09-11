using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiExample.Data;
using Microsoft.EntityFrameworkCore;
using ApiExample.Models;

namespace ApiExample.Controllers.V1.Owners;

[ApiController]
[Route("api/v1/owners")]
public class OwnersUpdateController : ControllerBase
{
    // Esta propiedad se va a encargar de darme la llave para entrar a la base de datos
    private readonly ApplicationDbContext Context;

    // Builder. Este constructor se va a encargar de hacerme la conexión con la base de datos, con la ayuda de la llave para entrar.
    public OwnersUpdateController(ApplicationDbContext context)
    {
        Context = context;
    }

    // Método Put para actualizar todos los campos de un propietario.
    [HttpPut("{id}")]
    public async Task<IActionResult> PutById([FromRoute] int id, [FromBody] Owner ownerUpdated)
    {
        // 1. Validar si el modelo es válido.
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        // 2. Buscar el propietario original en la base de datos por su ID.
        var ownerFound = await Context.Owners.FindAsync(id);

        // 3. Si no existe, devolver un 404 Not Found
        if (ownerFound == null)
        {
            return NotFound("Owner not found.");
        }

        // 4. Actualizar los campos del propietario existente con los datos recibidos
        ownerFound.Name = ownerUpdated.Name;
        ownerFound.LastName = ownerUpdated.LastName;
        ownerFound.ProfilePicture = ownerUpdated.ProfilePicture;
        ownerFound.NumberPhone = ownerUpdated.NumberPhone;
        ownerFound.Email = ownerUpdated.Email;

        // 5. Guardar los cambios en la base de datos
        await Context.SaveChangesAsync();

        // 6. Devolver un 200 OK con el recurso actualizado
        return Ok(ownerFound);
    }
}
