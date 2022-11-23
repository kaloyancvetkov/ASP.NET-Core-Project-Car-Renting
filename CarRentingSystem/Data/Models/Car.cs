using System.ComponentModel.DataAnnotations;
using static CarRentingSystem.Data.DataConstants;

namespace CarRentingSystem.Data.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(CarBrandMaxLength)]
        public string Brand { get; set; }

        [Required]
        [MaxLength(CarModelMaxLength)]
        public string Model { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Range(CarYearMinValue, CarYearMaxValue)]
        public int Year { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; init; }
    }
}
