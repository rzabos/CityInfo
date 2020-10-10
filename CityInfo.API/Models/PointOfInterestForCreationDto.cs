using System.ComponentModel.DataAnnotations;

namespace CityInfo.API.Models
{
    public class PointOfInterestForStuffDto
    {
        [Required(ErrorMessage = "This is a must bro.")]
        [MaxLength(200)]
        public string Description { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
    }
}