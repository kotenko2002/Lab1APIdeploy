using System.ComponentModel.DataAnnotations;

namespace Lab1API.DTOs
{
    public class CategoryAddModel
    {
        [Required]
        public string Name { get; set; }
    }
}
