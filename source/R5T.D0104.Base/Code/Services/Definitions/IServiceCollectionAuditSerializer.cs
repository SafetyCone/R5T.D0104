using System;
using System.Threading.Tasks;


namespace R5T.D0104
{
    /// <summary>
    /// Serializes the service collection of which it is a member for audit purposes.
    /// </summary>
    public interface IServiceCollectionAuditSerializer
    {
        Task SerializeServiceCollection();
    }
}
