using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Examen3.Entities
{
    public class Kind : BaseEntity
    {
        public string NameKind { get; set; }
        public ICollection<Toy>? Toys { get; set; }

    }
}