using Carter;
using Microsoft.AspNetCore.Routing;

namespace MailResenderr.Endpoints.MailResenderr;

public class MailResenderrGroup : CarterModule
{
    public MailResenderrGroup() : base("/mailresenderr")
    {
        WithTags(nameof(MailResenderr));
    }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.AddMailResenderrRoute();
    }
}