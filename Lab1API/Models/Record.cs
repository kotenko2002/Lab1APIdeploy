using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab1API.Models
{
    public class Record
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public DateTime CreatedOnUtc { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Sum { get; set; }
    }
}
