using System;
using System.ComponentModel.DataAnnotations;

namespace BenivoProject.Domain.Core
{
    public class Category:BaseEntity
    {
        [MaxLength(250)]
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Deleted { get; set; }
    }
}
