using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0104.I001
{
    [ServiceImplementationMarker]
    public class ConstructorBasedServiceCollectionSerializationFileNameProvider : IServiceCollectionSerializationFileNameProvider, IServiceImplementation
    {
        private string ServiceCollectionSerializationFileName { get; }


        public ConstructorBasedServiceCollectionSerializationFileNameProvider(
            [NotServiceComponent] string serviceCollectionSerializationFileName)
        {
            this.ServiceCollectionSerializationFileName = serviceCollectionSerializationFileName;
        }

        public Task<string> GetServiceCollectionSerializationFileName()
        {
            return Task.FromResult(this.ServiceCollectionSerializationFileName);
        }
    }
}
