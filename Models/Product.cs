using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProductApi.Models
{
    public class Product
    {
        [Key]                          // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-generated
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        public void Update(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
