using Microsoft.ServiceFabric.Services.Remoting;
using Phoenix.Common.Registration.Contract;
using System;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Phoenix.Manager.Registration.Interface
{
    [ServiceContract]
    public interface IRegistrationManager : IService
    {
        [OperationContract]
        Task<UserContract> CreateNewUser(Guid userObjectId, string firstName, string lastName);
    }
}
