using aws_multi_account_test_api.V1.Domain;

namespace aws_multi_account_test_api.V1.Factory
{
    public class TransactionFactory : AbstractTransactionFactory
    {
        public override Transaction FromUhTransaction(UhTransaction transaction)
        {
            return new Transaction
            {
                Balance = transaction.Balance,
                Code = transaction.Code,
                Date = transaction.Date
            };
        }
    }
}
