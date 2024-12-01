
namespace web_api_9_proj.Contracts.UserDtos;

public record UserBaseDto(string Name, string Surname, string Title)
{
    public string FullName => $"{Name} {Surname}";
};