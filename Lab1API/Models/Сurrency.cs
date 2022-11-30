using System.ComponentModel.DataAnnotations;

namespace Lab1API.Models
{
    public class Сurrency
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
