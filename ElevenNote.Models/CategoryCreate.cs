using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class CategoryCreate
    {
        [Required]
        [MinLength(2, ErrorMessage ="Name must be more than 2 characters.")]
        [MaxLength(150, ErrorMessage ="Too many characters for this field.")]
        public string Name { get; set; }
    }
}
