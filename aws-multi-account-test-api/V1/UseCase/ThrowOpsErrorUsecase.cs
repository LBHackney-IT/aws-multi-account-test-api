
namespace aws_multi_account_test_api.UseCase.V1
{
    public class ThrowOpsErrorUsecase
    {
        public static void  Execute()
        {
            throw new TestOpsErrorException();
        }
    }
}
