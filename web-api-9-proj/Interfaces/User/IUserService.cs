using web_api_9_proj.Contracts.UserDtos;

namespace web_api_9_proj.Interfaces;
/// <summary>
/// Rozhraní pro Uživatele
/// Umožňuje získat specifické data k uživateli
/// </summary>
public interface IUserService
{
    Task<UserBaseDto> GetUserByAgeAsync();
    Task<UserBaseDto> GetByEmail(string email);
    Task<UserBaseDto> GetOldestUserAsync();

}