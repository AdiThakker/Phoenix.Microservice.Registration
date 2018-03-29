using Phoenix.Access.Registration.Core.Entities;
using Phoenix.Access.Registration.Core.Interfaces;
using Phoenix.Access.Registration.Infrastructure.EntityFramework.Context;
using Phoenix.Access.Registration.Infrastructure.EntityFramework.Repositories.Base;

namespace Phoenix.Access.Registration.Infrastructure.EntityFramework.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository()
            : base(new RegistrationContext())
        {
        }

        public UserRepository(RegistrationContext context)
                : base(context)
        {
        }

        public User CreateNewUser(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new System.ArgumentException("Cannot be null or empty.", nameof(firstName));

            if (string.IsNullOrWhiteSpace(lastName))
                throw new System.ArgumentException("Cannot be null or empty.", nameof(lastName));

            return base.Add(new User() { FirstName = firstName, LastName = lastName });
        }
    }
}
