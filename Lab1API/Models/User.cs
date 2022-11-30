using System.ComponentModel.DataAnnotations;

namespace Lab1API.Models
{
    public class User
    {
        public int Id { get; set; }
        public int СurrencyId { get; set; }

        [Required]
        public string Name { get; set; }

        public Сurrency Сurrency { get; set; }
    }
}
