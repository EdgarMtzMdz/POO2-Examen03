using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace POO_Examen3.Entities
{
    public class Toy : BaseEntity
    {
    
    public string Name { get; set; }
    public Category? Category { get; set; }
    public string? NameCategory { get; set; }
    
    public Kind? Kind { get; set; }
    public string? NameKind { get; set; }
    public List<SelectListItem> CategoryList { get; set; }
    public List<SelectListItem> TypeList { get; set; }
    }
}