using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BookShop.Models
{
    public class JobListingModel
    {
        [Key]
        public int JobListingId { get; set; }

        [Required]
        public string? Title { get; set; }

        public string? Description { get; set; }

        public DateTime ApplicationDeadline { get; set; }

        [Required]
        public string? Location { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [ValidateNever]
        public Category? Category { get; set; }

        // Navigation property to reference the employer (IdentityUser)
        public ApplicationModel? Employer { get; set; }

        // Property to accept image file
        [NotMapped] // Exclude this property from the database schema
        [Display(Name = "Image")] // Display name for the input field
        [Required(ErrorMessage = "Please select an image.")]
        [DataType(DataType.Upload)]
        public IFormFile? ImageFile { get; set; }

        // Optional property to store the image path or byte array in the database
        public string? ImagePath { get; set; }
        public bool ImageUploaded { get; set; }

    }
}
