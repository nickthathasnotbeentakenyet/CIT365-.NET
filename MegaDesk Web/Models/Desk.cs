using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace MegaDesk_Web.Models
{
    public class Desk
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string firstName { get; set; } = string.Empty;

        [Display(Name = "Last Name")]
        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string lastName { get; set; } = string.Empty;

        [Display(Name = "Width")]
        [Range(24, 96)]
        [Required]
        public string deskWidth { get; set; } = string.Empty;

        [Display(Name = "Depth")]
        [Range(12, 48)]
        [Required]
        public string deskDepth { get; set; } = string.Empty;

        [Display(Name = "Rush Order Options")]
        [Required]
        public int rushOrder { get; set; }

        [Display(Name = "Drawers")]
        [Range(0, 7)]
        [Required]
        public int drawers { get; set; }

        [Display(Name = "Surface Material")]
        [Required]
        public string surfaceMaterial { get; set; } = string.Empty;

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime dateAdded { get; set; }

    }

    public enum surfaceMaterial
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }
    public enum rushOrder
    {
        [Display(Name = "None")]
        None = 0,
        [Display(Name = "3 Days")]
        Three = 3,
        [Display(Name = "5 Days")]
        Five = 5,
        [Display(Name = "7 Days")]
        Seven = 7,

    }

}
