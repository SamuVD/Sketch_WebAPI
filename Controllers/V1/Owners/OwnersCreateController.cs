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
[Route("api/[controller]")]
public class OwnersCreateController : ControllerBase
{
    // Esta propiedad se va a encargar de darme la llave para entrar a la base de datos
    private readonly ApplicationDbContext Context;

    // Builder. Este constructor se va a encargar de hacerme la conexión con la base de datos, con la ayuda de la llave para entrar.
    public OwnersCreateController(ApplicationDbContext context)
    {
        Context = context;
    }

    // Método Post para crear un nuevo propietario.
    [HttpPost("NewOwner")]
    public async Task<IActionResult> Post([FromBody]Owner owner)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        Context.Owners.Add(owner);
        await Context.SaveChangesAsync();
        return Ok(owner);
    }
}
