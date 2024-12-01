# Šablony pro přenos dat

Tyto soubory jsou třídy, které určují jaký bude výstup z API.

Jedná se o DTO (Data transfer object).

## Význam

Tyto objekty (`class`, `records` a další) určují rozdíl mezi strukturou dat v db a dat předávanými z API.

## Contracts

Ve složke Contracts jsou jednotlivé DTOs. které jsou použity v projektu.

### Základní objekt

Základem je `UserBaseDto.cs` obsahuje pouze nejnutnější položky z objektu `User.cs` jako je Jméno, příjmení a titul.
Objekt dto je o proti objektu modelu obohacen o položku celé jméno.

```csharp
public record UserBaseDto(string Name, string Surname, string Title)
{
    public string FullName => $"{Name} {Surname}";
};
```

### Rozšiřený objekt

Rozšířeným objektum je `UserDto.cs`, který přebírá všechny položky ze základního a rozšiřuje objekt o další položky

```csharp
public record UserDto(int Id, string Name, string Surname, string Title, string Email, string Phone, short Age) 
    : UserBaseDto(Name, Surname, Title);
```
