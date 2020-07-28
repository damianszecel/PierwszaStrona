using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FirstSite.Models
{
    public class Kategoria
    {
        public int KategoriaId { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwe kategorii")]
        [StringLength(100)]
        public string KatergoriaName { get; set; }
        [Required(ErrorMessage = "Wprowadz opis kategorii")]
        public string KategoriaDescription { get; set; }
        public string IconName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}