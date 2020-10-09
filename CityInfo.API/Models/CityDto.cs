using System.Collections.Generic;

namespace CityInfo.API.Models
{
    public class CityDto
    {
        public string Description { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public int NumberOfPointsOfInterest => PointsOfInterest.Count;

        public ICollection<PointOfInterestDto> PointsOfInterest { get; set; }
    }
}