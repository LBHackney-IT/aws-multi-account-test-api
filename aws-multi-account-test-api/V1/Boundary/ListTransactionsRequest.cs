

using System.ComponentModel.DataAnnotations;

namespace aws_multi_account_test_api.V1.Boundary
{
    public class ListTransactionsRequest
    {
        [Required] public string PropertyRef { get; set; }
    }
}
