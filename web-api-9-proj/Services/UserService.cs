
using web_api_9_proj.Contracts.UserDtos;
using web_api_9_proj.Interfaces;
using web_api_9_proj.Model;

namespace web_api_9_proj.Services;

/// <summary>
/// Služba pro práci s ostatními požadavky na data
/// </summary>
public class UserService : IUserService
{
    public async Task<UserBaseDto> GetByEmail(string email)
    {
        var usersDb = await new DummyUsers().Users();
        //získání uživatele
        var result = usersDb.Where(f => f.Email == email);
        if (result == null)
        {
            throw new ArgumentNullException("Uživatel s tímto emailem nenalezen");
        }

        return result
        .Select(s => new UserBaseDto(s.Name, s.Surname, s.Title)).FirstOrDefault() ?? throw new ArgumentNullException("Objekt nenalezen");
    }

    public Task<UserBaseDto> GetOldestUserAsync()
    {
        throw new NotImplementedException();
    }

    public Task<UserBaseDto> GetUserByAgeAsync()
    {
        throw new NotImplementedException();
    }
}