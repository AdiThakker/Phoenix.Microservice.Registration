using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Remoting.FabricTransport.Runtime;
using Microsoft.ServiceFabric.Services.Remoting.V1.FabricTransport.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;
using Phoenix.Common.Registration.Contract;
using Phoenix.Manager.Registration.Interface;
using System;
using System.Collections.Generic;
using System.Fabric;
using System.Threading.Tasks;

namespace Phoenix.Manager.Registration.Service
{
    /// <summary>
    /// An instance of this class is created for each service instance by the Service Fabric runtime.
    /// </summary>
    internal sealed class RegistrationManagerService : StatelessService, IRegistrationManager
    {
        public RegistrationManagerService(StatelessServiceContext context)
            : base(context)
        { }

        public Task<UserContract> CreateNewUser(Guid userObjectId, string firstName, string lastName)
        {
            return Task.FromResult(new UserContract() { UserObjectId = userObjectId, FirstName = firstName, LastName = lastName });
        }

        /// <summary>
        /// Optional override to create listeners (e.g., TCP, HTTP) for this service replica to handle client or user requests.
        /// </summary>
        /// <returns>A collection of listeners.</returns>
        protected override IEnumerable<ServiceInstanceListener> CreateServiceInstanceListeners()
        {
            return new List<ServiceInstanceListener>()
            {
                new ServiceInstanceListener((context) =>
                    {
                        return new FabricTransportServiceRemotingListener(context, this, new FabricTransportRemotingListenerSettings(){ EndpointResourceName = nameof(IRegistrationManager) });
                    })
            };
        }

    }
}
