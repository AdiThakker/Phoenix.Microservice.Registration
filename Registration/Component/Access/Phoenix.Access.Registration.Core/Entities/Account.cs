using Phoenix.Access.Registration.Core.Entities.Base;

namespace Phoenix.Access.Registration.Core.Entities
{
    public class Account : EntityBase<int>
    {
        public string AccountName { get; set; }

        public bool? IsActive { get; set; }
    }
}
