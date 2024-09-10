using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiExample.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiExample.Controllers.V1.Owners;

[ApiController]
[Route("api/[controller]")]
public class OwnersController : ControllerBase
{
    // Esta propiedad se va a encargar de darme la llave para entrar a la base de datos
    private readonly ApplicationDbContext Context;

    // Builder. Este constructor se va a encargar de hacerme la conexión con la base de datos, con la ayuda de la llave para entrar.
    public OwnersController(ApplicationDbContext context)
    {
        Context = context;
    }

    // Este método se va a encargar de traer todos los propietarios que existen en la base de datos
    // [HttpGet]
    // public async Task<IActionResult> Get()
    // {
    //     var GetAllDatasOfTheDB = await KeyToOpenDB.Owners.ToListAsync();

    //     return Ok(GetAllDatasOfTheDB);
    // }

    // Este método se va a encargar de traer un propietario por su nombre
    // [HttpGet("GetOwnerByName")]
    // public async Task<IActionResult> Get()
    // {
    //     var getOneOwnerForTheName = await KeyToOpenDB.Owners.FirstOrDefaultAsync(item => item.Name == "alejo");

    //     if (getOneOwnerForTheName == null)
    //     {
    //         return NotFound("No hay ningún propietario");
    //     }
    //     else
    //     {
    //         return Ok(getOneOwnerForTheName);
    //     }
    // }

    // // Este método se va a encargar de traer un propietario por su Id
    // [HttpGet("GetOwnerById/{id}")]
    // public async Task<IActionResult> GetOwnerById(int id)
    // {
    //     var oneOwnerById = await KeyToOpenDB.Owners.FindAsync(id);

    //     return Ok(oneOwnerById);
    // }
}
