using Microsoft.EntityFrameworkCore;
using aws_multi_account_test_api.V1.Domain;

namespace aws_multi_account_test_api.V1.Infrastructure
{
    public class UhContext : DbContext, IUHContext
    {
        public UhContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UhTransaction> UTransactions { get; set; }
    }
}
