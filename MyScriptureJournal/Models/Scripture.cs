using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }

        [StringLength(15, MinimumLength = 3)]
        [Required]
        [Display(Name = "Book Name")]
        public string BookName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Range(1, 100)]
        [Column(TypeName = "int()")]
        public int Chapter { get; set; }

        [Range(1, 100)]
        [Column(TypeName = "int()")]
        public int Verse { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(500)]
        public string Note { get; set; }
        
    }
}
