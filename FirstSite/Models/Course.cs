using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstSite.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public int KategoriaId { get; set; }
        public string TitleCourse { get; set; }
        public string AuthorCourse { get; set; }
        public DateTime AddingDate { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Price { get; set; }
        public bool Hidden { get; set; }

        public virtual Kategoria Kategoria { get; set; }
    }
}