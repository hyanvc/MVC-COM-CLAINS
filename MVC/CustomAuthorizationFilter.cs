using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

public class CustomAuthorizationFilter /*: IAuthorizationFilter*/
{
    private readonly string[] _roles;

    public CustomAuthorizationFilter(string[] roles)
    {
        _roles = roles;
    }

    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var logger = context.HttpContext.RequestServices.GetService<ILogger<CustomAuthorizationFilter>>();

        // Verificar se o usuário está autenticado
        if (!context.HttpContext.User.Identity.IsAuthenticated)
        {
            context.Result = new ChallengeResult();
            return;
        }

        // Verificar se o usuário possui uma das roles especificadas
        if (!context.HttpContext.User.HasClaim(c => c.Type == ClaimTypes.Role && _roles.Contains(c.Value)))
        {
            logger.LogInformation($"User {context.HttpContext.User.Identity.Name} attempted to access a resource without the required roles.");
            context.Result = new ForbidResult();
            return;
        }
    }
}