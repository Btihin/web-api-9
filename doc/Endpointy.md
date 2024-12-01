# Rozvržení koncových bodů

Základní soubor projektu `Program.cs`. obsahuje configuraci a koncové body rozhraní.

## Use end points

Do `Program.cs` je zaveden Use pro endpointy usera

```csharp
app.MapUserEndpoints();
```

Tato funkce odkazuje na middleware v složce EndPoints

## Endpoints

složka podobně jako controllers, bude seskupovat do souborů jednotlivé akce tedy výchozí body.

### UserEndpoints

zaveden soubor `UserEndpoints.cs` ve kterém budou všechny endpointy pro Uživatele

#### Funkce Map

jedná se o statickou class `UserEndpoint.cs` která má funkci `MapUserEndpoints()` s Parametrem `IendpointRouteBuilder` z `program.cs`

Tato funkce je následně předána do `Program.cs`.

##### Sekce User

ve funkci Map bude zevedena routa `/user`, aby všechny endpointy pro uživatele měli v url strukturu `http://example.com/user/danaFunkce`

```csharp
var group = endpoint.MapGroup("/user");
```

##### Routy

Pro každou routu (end point) je vytvořena anonymní funkce.

Pro každý endpoint vytvořeny funkce: na vytažení všech uživatelů nebo vytažení uživatele dle ID.
```csharp
group.MapGet("/getall", async () => {
    var users = await new UserRepositories().GetAll();
    return Results.Ok(users);
});
```
