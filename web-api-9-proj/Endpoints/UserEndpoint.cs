
using Microsoft.AspNetCore.Http.HttpResults;
using web_api_9_proj.Repositories;

namespace web_api_9_proj.Endpoints;
public static class UserEndpoint
{

    public static void MapUserEndpoints(this IEndpointRouteBuilder endpoint)
    {
        var group = endpoint.MapGroup("/user");

        #region získat všechny uživatele
        group.MapGet("/getall", async () =>
        {
            var users = await new UserRepositories().GetAll();
            return Results.Ok(users);
        });
        #endregion

        #region získat uživatele dle id
        group.MapGet("/getbyid/{id}", async (int id) =>
        {
            var user = await new UserRepositories().GetById(id);
            if (user == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(user);
        });
        #endregion
    }
}