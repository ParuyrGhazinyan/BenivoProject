using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BenivoProject.Domain.Core
{
    public class User:BaseEntity
    {       
        [MaxLength(250)]
        public string UserName { get; set; }
        [MaxLength(250)]
        public string Password { get; set; }
        public int RoleId { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        public virtual ICollection<Bookmark> Bukmarks { get; set; }
    }
}
