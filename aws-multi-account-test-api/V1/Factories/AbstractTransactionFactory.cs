using System.Collections.Generic;
using System.Linq;
using aws_multi_account_test_api.V1.Domain;

namespace aws_multi_account_test_api.V1.Factory
{
    public abstract class AbstractTransactionFactory
    {
        public abstract Transaction FromUhTransaction(UhTransaction transaction);

        public List<Transaction> FromUhTransaction(IEnumerable<UhTransaction> result)
        {
            return result.Select(FromUhTransaction).ToList();
        }
    }
}
