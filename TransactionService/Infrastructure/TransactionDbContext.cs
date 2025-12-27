using Microsoft.EntityFrameworkCore;
using TransactionService.Domain;

namespace TransactionService.Infrastructure;

public class TransactionDbContext(DbContextOptions<TransactionDbContext> options) : DbContext(options)
{
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Category> Categories { get; set; }
}