using System.ComponentModel.DataAnnotations;

namespace IT3047C_FinalProject.Models
{
    public class RecHobbies
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "To")]
        [Required(ErrorMessage = "Please enter who the recommendation is for.")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Type of Hobby")]
        [Required(ErrorMessage = "Please enter in the hobby type.")]
        public string hobbyType { get; set; }

        [Display(Name = "Recommendation")]
        [Required(ErrorMessage = "Please enter in your recommendation.")]
        public string recommendedHobby { get; set; }

        [Display(Name = "Recommended by")]
        public string? userName { get; set; }

    }
}
