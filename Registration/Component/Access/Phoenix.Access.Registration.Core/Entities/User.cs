using Phoenix.Access.Registration.Core.Entities.Base;
using Phoenix.Access.Registration.Core.Interfaces.Base;

namespace Phoenix.Access.Registration.Core.Entities
{
    public class User : EntityBase<int>, IEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
