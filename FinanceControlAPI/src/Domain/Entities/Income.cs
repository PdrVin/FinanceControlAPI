using Domain.Enums;

namespace Domain.Entities;

    public class Income
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public PayType Type { get; set; }
        public required DateTime Date { get; set; }
        public required string Description { get; set; }
        public required string Category { get; set; }
        public Account Account { get; set; }
        public decimal Amount { get; set; }
    }
