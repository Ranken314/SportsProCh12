using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace SportsPro.Models
{
    public class Registraion
    {
        // Composite primary key and foreign keys

        [Required]
        public int CustomerID { get; set; }

        [Required]
        public int ProductID { get; set; }

        // Navigation properies
        public Customer? Customer { get; set; }
        public Product? Product { get; set; }
    }
}
