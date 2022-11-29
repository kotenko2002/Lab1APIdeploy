using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab1API.DTOs
{
    public class RecordAddModel
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public DateTime CreatedOnUtc { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Sum { get; set; }
    }
}
