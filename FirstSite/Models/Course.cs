using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstSite.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public int KategoriaId { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwe kursu")]
        [StringLength(100)]
        public string TitleCourse { get; set; }
        [Required(ErrorMessage = "Wprowadz autora kursu")]
        [StringLength(50)]
        public string AuthorCourse { get; set; }
        public DateTime AddingDate { get; set; }
        [StringLength(100)]
        public string FileName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Bestseller { get; set; }
        public bool Hidden { get; set; }

        public virtual Kategoria Kategoria { get; set; }
    }
}