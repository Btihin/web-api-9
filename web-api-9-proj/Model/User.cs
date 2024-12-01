namespace web_api_9_proj.Model;

public class User()
{

    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Surname { get; set; }
    public string? Title { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public short? Age { get; set; }
}