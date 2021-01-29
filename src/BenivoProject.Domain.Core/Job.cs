using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BenivoProject.Domain.Core
{
    public class Job:BaseEntity
    {
        [MaxLength(500)]
        public string Title { get; set; }
        public string Image { get; set; }
        public string Company { get; set; }
        public int CategoriId { get; set; }
        public int LocationId { get; set; }
        public string Details { get; set; }
        public int EmploymentTypeId { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey("EmploymentTypeId")]
        public EmploymentType EmploymentType { get; set; }
        [ForeignKey("CategoriId")]
        public virtual Category Category { get; set; }
        [ForeignKey("LocationId")]
        public virtual Location Location { get; set; }

        public virtual ICollection<Bookmark> Bukmarks { get; set; }
    }
}
