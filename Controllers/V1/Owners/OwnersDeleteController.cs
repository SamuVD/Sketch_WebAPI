using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiExample.Data;
using Microsoft.EntityFrameworkCore;

namespace ApiExample.Controllers.V1.Owners;

[ApiController]
[Route("api/v1/owners")]
public class OwnersDeleteController : ControllerBase
{
    // Esta propiedad se va a encargar de darme la llave para entrar a la base de datos
    private readonly ApplicationDbContext Context;

    // Builder. Este constructor se va a encargar de hacerme la conexión con la base de datos, con la ayuda de la llave para entrar.
    public OwnersDeleteController(ApplicationDbContext context)
    {
        Context = context;
    }

    // Método Delete para eliminar a un propietario.
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var ownerDeletedByYourId = await Context.Owners.FindAsync(id);
        
        if (ownerDeletedByYourId == null)
        {
            return NotFound("No owner found with that ID");
        }
        Context.Owners.Remove(ownerDeletedByYourId);
        await Context.SaveChangesAsync();
        return NoContent();
    }
}
