using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }
        public string BookName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

        public int Chapter { get; set; }

        public int Verse { get; set; }

        public string Note { get; set; }
        
    }
}
