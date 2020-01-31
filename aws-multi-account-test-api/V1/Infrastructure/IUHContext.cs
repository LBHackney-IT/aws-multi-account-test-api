using Microsoft.EntityFrameworkCore;
using aws_multi_account_test_api.V1.Domain;

namespace aws_multi_account_test_api.V1.Infrastructure
{
    public interface IUHContext
    {
        DbSet<UhTransaction> UTransactions { get; set; }
    }
}
