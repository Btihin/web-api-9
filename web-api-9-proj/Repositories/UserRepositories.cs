using web_api_9_proj.Contracts.UserDtos;
using web_api_9_proj.Interfaces;
using web_api_9_proj.Model;

namespace web_api_9_proj.Repositories;

/// <summary>
/// Služba pro vytažení základních CRUD funkcí nad Uživatelem
/// </summary>
public class UserRepositories : IUserRepository
{
    /// <summary>
    /// Vytvořit nového uživatele
    /// </summary>
    /// <param name="user">instance uživatele</param>
    public async Task CreateUser(User user)
    {
        var users = await new DummyUsers().Users();
        users.Add(user);
    }

    /// <summary>
    /// Funkce pro vytažení seznamu uživatelů
    /// </summary>
    /// <returns>Vrací list uživatelů</returns>
    public async Task<IEnumerable<User>> GetAll()
    {
        var users = await new DummyUsers().Users();
        return users;
    }


    /// <summary>
    /// Najde uživatele dle Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<User> GetById(int id)
    {
        var user = await new DummyUsers().Users();
        var result = user.FirstOrDefault(f => f.Id == id);
        if (result == null)
        {
            throw new ArgumentException("Uživatel nenalezen");
        }
        return result;
    }

    /// <summary>
    /// Aktualizuje uživatele
    /// </summary>
    /// <param name="user">instance uživatele</param>
    /// <exception cref="ArgumentException">Vyjímka pokud uživatel neexistuje</exception>
    public async Task UpdateUser(User user)
    {
        var userDb = await GetById(user.Id);
        if (userDb == null)
        {
            throw new ArgumentException("Uživatel nenalezen");
        }

        userDb.Name = user.Name;
        userDb.Surname = user.Surname;
        userDb.Title = user.Title;
        userDb.Email = user.Email;
        userDb.Phone = user.Phone;
        userDb.Age = user.Age;

    }
}