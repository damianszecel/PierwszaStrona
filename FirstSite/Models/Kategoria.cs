using System.Collections;
using System.Collections.Generic;

namespace FirstSite.Models
{
    public class Kategoria
    {
        public int KategoriaId { get; set; }
        public string KatergoriaName { get; set; }
        public string KategoriaDescription { get; set; }
        public string IconName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}