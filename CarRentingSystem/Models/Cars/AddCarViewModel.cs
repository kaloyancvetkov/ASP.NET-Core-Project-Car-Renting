using System.ComponentModel.DataAnnotations;

namespace CarRentingSystem.Models.Cars
{
    public class AddCarViewModel
    {
        public string Brand { get; init; }

        public string Model { get; init; }

        public string Description { get; init; }

        [Display(Name = "Image URL")]
        public string ImageUrl { get; init; }

        public int Year { get; init; }

        public int CategoryId { get; init; }
    }
}
