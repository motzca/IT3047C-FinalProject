using System.ComponentModel.DataAnnotations;

namespace IT3047C_FinalProject.Models
{
    public class Dakota
    {
        [Key]
        public int HobbyId { get; set; } //primary key

        [Display(Name ="Hobby Name")]
        public string HobbyName { get; set; } = null!;

        [Display(Name = "Favorite Type(s) of the Hobby")]
        public string HobbyType { get; set; } = null!;
    }
}
