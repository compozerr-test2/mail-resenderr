using Core.Feature;
using Microsoft.Extensions.DependencyInjection;
using MailResenderr.Services;

namespace MailResenderr;

public class MailResenderrFeature : IFeature
{

    void IFeature.ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<IMailResenderrService, MailResenderrService>();
    }
}