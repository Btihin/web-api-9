namespace web_api_9_proj.Contracts.UserDtos;
public record UserDto(int Id, string Name, string Surname, string Title, string Email, string Phone, short Age) : UserBaseDto(Name, Surname, Title);