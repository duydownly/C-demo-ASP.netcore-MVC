using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Category
    {
        [Key]  // Ensure Id is the primary key
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
