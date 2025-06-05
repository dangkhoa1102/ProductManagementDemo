using BusinessObjects;

namespace Services
{
    public interface IAccountService
    {
        AccountMember AccountMember(string accountID);
    }
}
