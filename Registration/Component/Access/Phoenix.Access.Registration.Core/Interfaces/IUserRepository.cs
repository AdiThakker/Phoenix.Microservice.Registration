using Phoenix.Access.Registration.Core.Entities;
using Phoenix.Access.Registration.Core.Interfaces.Base;

namespace Phoenix.Access.Registration.Core.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User CreateNewUser(string firstName, string lastName);
    }
}
