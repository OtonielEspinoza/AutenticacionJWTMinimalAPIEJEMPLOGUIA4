using AutenticacionJWTMinimalAPIEJEMPLOGUIA4.Auth;

namespace AutenticacionJWTMinimalAPIEJEMPLOGUIA4.Endpoints
{
    public static class AccountEnpoint
    {

        public static void AddAccountEndpoints(this WebApplication app)
        {



            app.MapPost("/account/login", (string login, string password, IJwtAuthenticationService authService) =>
            {
                if (login == "admin" && password == "1235")
                {
                    var token = authService.Authenticate(login);

                    return Results.Ok(token);
                }
                else
                {
                    return Results.Unauthorized();
                }
            });
        }
    }
}
