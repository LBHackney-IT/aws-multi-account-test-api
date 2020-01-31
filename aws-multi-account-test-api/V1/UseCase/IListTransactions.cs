namespace aws_multi_account_test_api.V1.Boundary
{
    public interface IListTransactions
    {
        ListTransactionsResponse Execute(ListTransactionsRequest propertyRefrence);
    }
}
