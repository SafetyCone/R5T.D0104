using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0048;
using R5T.T0063;


namespace R5T.D0104.I001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ServiceCollectionAuditSerializer"/> implementation of <see cref="IServiceCollectionAuditSerializer"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddServiceCollectionAuditSerializer(this IServiceCollection services,
            IServiceAction<IServiceCollection> serviceCollectionAction,
            IServiceAction<IServiceCollectionSerializationFilePathProvider> serviceCollectionSerializationFilePathProviderAction)
        {
            services
                .Run(serviceCollectionAction)
                .Run(serviceCollectionSerializationFilePathProviderAction)
                .AddSingleton<IServiceCollectionAuditSerializer, ServiceCollectionAuditSerializer>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ServiceCollectionSerializationFilePathProvider"/> implementation of <see cref="IServiceCollectionSerializationFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddServiceCollectionSerializationFilePathProvider(this IServiceCollection services,
            IServiceAction<IOutputFilePathProvider> outputFilePathProviderAction,
            IServiceAction<IServiceCollectionSerializationFileNameProvider> serviceCollectionSerializationFileNameProviderAction)
        {
            services
                .Run(outputFilePathProviderAction)
                .Run(serviceCollectionSerializationFileNameProviderAction)
                .AddSingleton<IServiceCollectionSerializationFilePathProvider, ServiceCollectionSerializationFilePathProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ConstructorBasedServiceCollectionSerializationFileNameProvider"/> implementation of <see cref="IServiceCollectionSerializationFileNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddConstructorBasedServiceCollectionSerializationFileNameProvider(this IServiceCollection services,
            string serviceCollectionSerializationFileName)
        {
            services.AddSingleton<IServiceCollectionSerializationFileNameProvider>(_ => new ConstructorBasedServiceCollectionSerializationFileNameProvider(
                serviceCollectionSerializationFileName));

            return services;
        }
    }
}