namespace TransactionService.Domain;

public class Transaction
{
    public Guid Id { get; init; }
    public decimal Amount { get; set; }
    public TransactionType Type { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid? CategoryId { get; set; }
    public Category? Category { get; set; }
}