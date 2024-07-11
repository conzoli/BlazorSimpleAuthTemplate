using BlazorSimpleAuthTemplate.Models.Entities;

namespace BlazorSimpleAuthTemplate.Services;

public interface IUserAccountService
{

    Task<UserAccount?> GetUserAccountAsync(string username);

    Task<IEnumerable<UserAccount>> GetAccountsAsync();

    Task<int> AddUserAccountAsync(UserAccount userAccount);

    Task<bool> UpdateUserAccountAsync(UserAccount userAccount);

    Task<bool> DeleteUserAccountAsync(UserAccount userAccount);

}
