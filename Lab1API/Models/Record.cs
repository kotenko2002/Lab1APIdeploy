using System;

namespace Lab1API.Models
{
    public class Record
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public decimal Sum { get; set; }
    }
}
