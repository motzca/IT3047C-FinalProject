using System.ComponentModel.DataAnnotations;

namespace IT3047C_FinalProject.Models
{
    public class Shared
    {
        [Key]
        public int SharedHobbyId { get; set; } //primary key

        [Display(Name = "Hobby Name")]
        public string SharedHobbyName { get; set; }
    }
}
