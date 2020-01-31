using System.Collections.Generic;
using aws_multi_account_test_api.V1.Domain;

namespace aws_multi_account_test_api.V1.Gateways
{
    public interface ITransactionsGateway
    {
        List<Transaction> GetTransactionsByPropertyRef(string propertyRef);
    }
}
