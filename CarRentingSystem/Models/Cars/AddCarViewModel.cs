using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static CarRentingSystem.Data.DataConstants;

namespace CarRentingSystem.Models.Cars
{
    public class AddCarViewModel
    {
        [Required]
        [StringLength(CarBrandMaxLength, MinimumLength = CarBrandMinLength)]
        public string Brand { get; init; }

        [Required]
        [StringLength(CarModelMaxLength, MinimumLength = CarModelMinLength)]

        public string Model { get; init; }

        [Required]
        [StringLength(int.MaxValue, MinimumLength = CarDescriptionMinLength, ErrorMessage = "The field Description must be a string with a minimum length of 10 characters.")]
        public string Description { get; init; }

        [Required]
        [Display(Name = "Image URL")]
        [Url]
        public string ImageUrl { get; init; }

        [Range(CarYearMinValue,CarYearMaxValue)]
        public int Year { get; init; }

        [Display(Name = "Category")]
        public int CategoryId { get; init; }

        public IEnumerable<CarCategoryViewModel> Categories { get; set; } = new List<CarCategoryViewModel>();
    }
}
