using Phoenix.Access.Registration.Core.Interfaces.Base;
using System;

namespace Phoenix.Access.Registration.Core.Entities.Base
{
    public abstract class EntityBase<T> : IEntity
    {
        public T Id { get; set; }

        public Byte[] TimeStamp { get; set; }
    }
}
