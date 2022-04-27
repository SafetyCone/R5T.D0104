using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0104
{
    /// <summary>
    /// Serializes the service collection of which it is a member for audit purposes.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IServiceCollectionAuditSerializer : IServiceDefinition
    {
        Task SerializeServiceCollection();
    }
}
