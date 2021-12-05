using System;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using R5T.D0104;


namespace System
{
    public static class IHostExtensions
    {
        public static async Task<IHost> SerializeServiceCollectionAudit(this Task<IHost> gettingHost)
        {
            var host = await gettingHost;

            await host.SerializeServiceCollectionAudit();

            return host;
        }

        public static async Task<IHost> SerializeServiceCollectionAudit(this IHost host)
        {
            var serviceCollectionAuditSerializer = host.Services.GetRequiredService<IServiceCollectionAuditSerializer>();

            await serviceCollectionAuditSerializer.SerializeServiceCollection();

            return host;
        }
    }
}