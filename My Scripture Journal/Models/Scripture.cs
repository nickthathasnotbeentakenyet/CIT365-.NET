using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Scripture_Journal.Models
{
    public class Scripture
    {
        public int ID { get; set; }
        public string Book { get; set; } = string.Empty;

        [Display(Name = "Verse")]
        public string Chapter { get; set; } = string.Empty;

        [Display(Name = "Date Added")]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Scripture Ref")]
        public string ScriptureBody { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
    }
}
