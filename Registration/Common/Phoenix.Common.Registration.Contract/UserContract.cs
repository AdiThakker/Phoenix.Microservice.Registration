using System;
using System.Runtime.Serialization;

namespace Phoenix.Common.Registration.Contract
{
    [DataContract]
    public class UserContract
    {
        [DataMember]
        public Guid UserObjectId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

    }
}
