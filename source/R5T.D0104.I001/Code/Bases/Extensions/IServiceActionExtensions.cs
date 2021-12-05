using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0048;
using R5T.T0062;
using R5T.T0063;


namespace R5T.D0104.I001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ServiceCollectionAuditSerializer"/> implementation of <see cref="IServiceCollectionAuditSerializer"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IServiceCollectionAuditSerializer> AddServiceCollectionAuditSerializerAction(this IServiceAction _,
            IServiceAction<IServiceCollection> serviceCollectionAction,
            IServiceAction<IServiceCollectionSerializationFilePathProvider> serviceCollectionSerializationFilePathProviderAction)
        {
            var serviceAction = _.New<IServiceCollectionAuditSerializer>(services => services.AddServiceCollectionAuditSerializer(
                serviceCollectionAction,
                serviceCollectionSerializationFilePathProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="ServiceCollectionSerializationFilePathProvider"/> implementation of <see cref="IServiceCollectionSerializationFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IServiceCollectionSerializationFilePathProvider> AddServiceCollectionSerializationFilePathProviderAction(this IServiceAction _,
            IServiceAction<IOutputFilePathProvider> outputFilePathProviderAction,
            IServiceAction<IServiceCollectionSerializationFileNameProvider> serviceCollectionSerializationFileNameProviderAction)
        {
            var serviceAction = _.New<IServiceCollectionSerializationFilePathProvider>(services => services.AddServiceCollectionSerializationFilePathProvider(
                outputFilePathProviderAction,
                serviceCollectionSerializationFileNameProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="ConstructorBasedServiceCollectionSerializationFileNameProvider"/> implementation of <see cref="IServiceCollectionSerializationFileNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IServiceCollectionSerializationFileNameProvider> AddConstructorBasedServiceCollectionSerializationFileNameProviderAction(this IServiceAction _,
            string serviceCollectionSerializationFileName)
        {
            var serviceAction = _.New<IServiceCollectionSerializationFileNameProvider>(services => services.AddConstructorBasedServiceCollectionSerializationFileNameProvider(
                serviceCollectionSerializationFileName));

            return serviceAction;
        }
    }
}
