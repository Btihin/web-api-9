using web_api_9_proj.Contracts.UserDtos;
using web_api_9_proj.Model;

namespace web_api_9_proj.Interfaces;

/// <summary>
/// Rozhraní pro základní CRUD operace nad Uživatelem
/// </summary>
public interface IUserRepository
{
    Task<IEnumerable<User>> GetAll();
    Task<User> GetById(int id);
    Task CreateUser(User user);
    Task UpdateUser(User user);
}