using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using MailResenderr.Services;

namespace MailResenderr.Endpoints.MailResenderr;

public static class MailResenderrRoute
{
    public static RouteHandlerBuilder AddMailResenderrRoute(this IEndpointRouteBuilder app)
    {
        return app.MapGet("/", (string name, IMailResenderrService mailresenderrService) => new GetMailResenderrResponse($"Hello, {mailresenderrService.GetObfuscatedName(name)}!"));
    }
}