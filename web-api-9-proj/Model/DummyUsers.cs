
namespace web_api_9_proj.Model;

/// <summary>
/// Dummy model pro data uživatelů
/// </summary>
public class DummyUsers
{
    /// <summary>
    /// Funkce pro vrácení dummy daty uživatelů
    /// </summary>
    /// <returns></returns>
    public async Task<List<User>> Users()
    {
        await Task.Delay(100);
        return new List<User>()
        {
            new User() {Id=1,Name="John", Surname= "Doe",Title= "Mr.", Email="john.doe@example.com",Phone= "+1-555-1234", Age=30},
            new User() {Id=2,Name="Jane", Surname= "Smith",Title= "Ms.", Email="jane.smith@example.com",Phone= "+1-555-5678", Age=25},
            new User() {Id=3,Name="Michael", Surname= "Johnson",Title= "Dr.", Email="michael.johnson@example.com",Phone= "+1-555-9876", Age=40},
            new User() {Id=4,Name="Emily", Surname= "Brown",Title= "Mrs.", Email="emily.brown@example.com",Phone= "+1-555-6543", Age=35},
            new User() {Id=5,Name="William", Surname= "Jones",Title= "Prof.", Email="william.jones@example.com",Phone= "13551654", Age=22},
            new User() {Id=6,Name="Emma", Surname= "Garcia",Title= "Miss", Email="emma.garcia@example.com",Phone= "4616548468",Age= 16}
        };
    }
}