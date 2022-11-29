using System.ComponentModel.DataAnnotations;

namespace Lab1API.DTOs
{
    public class UserAddModel
    {
        [Required]
        public string Name { get; set; }
    }
}
