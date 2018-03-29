using Phoenix.Common.Registration.Contract;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Phoenix.Access.Registration.Interface
{
    [ServiceContract]
    public interface IRegistrationAccess
    {
        [OperationContract]
        Task<UserContract> CreateNewUser(string firstName, string lastName);
    }
}
