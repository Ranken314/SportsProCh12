using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace SportsPro.Models
{
    public class Country
    {
        [Required]
        public string? CountryID { get; set; }

        [Required]
        public string CountryName { get; set; } = string.Empty;
    }
}
