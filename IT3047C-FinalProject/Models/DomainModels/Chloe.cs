using System.ComponentModel.DataAnnotations;

namespace IT3047C_FinalProject.Models
{
    public class Chloe
    {
        public int HobbyId { get; set; }

        [Display(Name ="Hobby Name")]
        public string HobbyName { get; set; }

        [Display(Name = "Favorite Types")]
        public string HobdyType { get; set; }
    }
}
