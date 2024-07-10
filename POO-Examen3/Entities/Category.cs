using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Examen3.Entities
{
    public class Category : BaseEntity
    {
        public string NameCategory { get; set; }
        public ICollection<Toy>? Toys { get; set; }
    }
}