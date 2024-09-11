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
public class OwnersReadController : ControllerBase
{
    // Esta propiedad se va a encargar de darme la llave para entrar a la base de datos
    private readonly ApplicationDbContext Context;

    // Builder. Este constructor se va a encargar de hacerme la conexión con la base de datos, con la ayuda de la llave para entrar.
    public OwnersReadController(ApplicationDbContext context)
    {
        Context = context;
    }

    // Método Get para traer a un propietario por el ID
    [HttpGet("GetById/{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id)
    {
        var showOwnerById = await Context.Owners.FindAsync(id);

        if (showOwnerById == null)
        {
            return NotFound("The ID is not registered.");
        }
        return Ok(showOwnerById);
    }

    // Método Get para traer a todos los propietarios existentes en la entidad de la base de datos.
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var getAllOwners = await Context.Owners.Select(item => item).ToListAsync();

        return Ok(getAllOwners);
    }
}
