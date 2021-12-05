using System;
using System.Threading.Tasks;

using R5T.D0048;
using R5T.T0064;


namespace R5T.D0104.I001
{
    [ServiceImplementationMarker]
    public class ServiceCollectionSerializationFilePathProvider : IServiceCollectionSerializationFilePathProvider, IServiceImplementation
    {
        private IOutputFilePathProvider OutputFilePathProvider { get; }
        private IServiceCollectionSerializationFileNameProvider ServiceCollectionSerializationFileNameProvider { get; }


        public ServiceCollectionSerializationFilePathProvider(
            IOutputFilePathProvider outputFilePathProvider,
            IServiceCollectionSerializationFileNameProvider serviceCollectionSerializationFileNameProvider)
        {
            this.OutputFilePathProvider = outputFilePathProvider;
            this.ServiceCollectionSerializationFileNameProvider = serviceCollectionSerializationFileNameProvider;
        }

        public async Task<string> GetServiceCollectionSerializationFilePath()
        {
            var serviceCollectionSerializationFileName = await this.ServiceCollectionSerializationFileNameProvider.GetServiceCollectionSerializationFileName();

            var output = await this.OutputFilePathProvider.GetOutputFilePath(serviceCollectionSerializationFileName);
            return output;
        }
    }
}
