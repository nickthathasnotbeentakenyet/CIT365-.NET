using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace SacramentMeeting.Models
{
    public class Meeting
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string President { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Conductor { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Opening Hymn")]
        public string OpeningHymn { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Invocation")]
        public string OpeningPrayer { get; set; }


        [Display(Name = "Intermediate Hymn")]
        public string? IntermediateHymn { get; set; }


        public int? Speakers { get; set; }
        [DataType(DataType.Text)]
        public string? SpeakerSubject { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Closing Hymn")]
        public string ClosingHymn { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Benediction")]
        public string ClosingPrayer { get; set; }
    }
}
