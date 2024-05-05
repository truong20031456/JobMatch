using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class ApplicationModel
    {
        [Key]
        public int ApplicationId { get; set; }

        [Required]
        public int JobListingId { get; set; }

        [Required]
        public string? Message { get; set; }

        // Navigation property if needed
        public string? Description { get; set; }

        public bool? status { get; set; }

    }
}
