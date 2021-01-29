using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BenivoProject.Domain.Core
{
    public class Role:BaseEntity
    {
        [MaxLength(150)]
        public string Name { get; set; }
        
        public virtual ICollection<User> Users { get; set; }        
    }
}
