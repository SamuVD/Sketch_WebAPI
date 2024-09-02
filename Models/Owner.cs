using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExample.Models;

public class Owner
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string IdNumber { get; set; }
    public string Address { get; set; }
    public string NumberPhone { get; set; }
    public string Email { get; set; }
}
