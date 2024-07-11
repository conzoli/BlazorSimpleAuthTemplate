using BlazorSimpleAuthTemplate.Models.Entities;

namespace BlazorSimpleAuthTemplate.Services;

public class InMemoryUserAccountService : IUserAccountService
{

    private readonly List<UserAccount> _userAccounts = [];

    public InMemoryUserAccountService()
    {
        var User1 = new UserAccount(){
            UserName = "oliver",
            Password = "password",
            Id = 1,
            Role = "Admin"
        };
        _userAccounts.Add(User1);
    }

    public async Task<int> AddUserAccountAsync(UserAccount userAccount)
    {
        userAccount.Id = _userAccounts.Count + 1;
        _userAccounts.Add(userAccount);
        return await Task.FromResult(userAccount.Id);
    }

    public Task<bool> DeleteUserAccountAsync(UserAccount userAccount)
    {
        return Task.FromResult(_userAccounts.Remove(userAccount));
    }

    public async Task<IEnumerable<UserAccount>> GetAccountsAsync()
    {
        await Task.CompletedTask;
        return _userAccounts;
    }

    public async Task<UserAccount?> GetUserAccountAsync(string username)
    {
        UserAccount? account = _userAccounts.FirstOrDefault(a => a.UserName == username);
        return await Task.FromResult(account );
    }

    public Task<bool> UpdateUserAccountAsync(UserAccount userAccount)
    {
        var existingAccount = _userAccounts.FirstOrDefault(a => a.Id == userAccount.Id);
        if (existingAccount != null)
        {
            existingAccount.UserName = userAccount.UserName;
            existingAccount.Password = userAccount.Password;
            return Task.FromResult(true);
        }

        return Task.FromResult(false);
    }
}
