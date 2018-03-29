using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Phoenix.Access.Registration.Infrastructure.EntityFramework.Context;
using Phoenix.Access.Registration.Infrastructure.EntityFramework.Repositories;
using System.Linq;

namespace Phoenix.Access.Registration.UnitTest
{
    [TestClass]
    public class InfrastructureUnitTests
    {
        [TestMethod]
        public void Create_New_User()
        {
            var options = new DbContextOptionsBuilder<RegistrationContext>()
               .UseInMemoryDatabase(databaseName: "In_Memory_Db")
               .Options;

            using (var dbContext = new RegistrationContext(options))
            {
                UserRepository userRepo = new UserRepository(dbContext);
                Assert.IsNotNull(userRepo.CreateNewUser("Hello", "Friend"));
                Assert.IsTrue(dbContext.Users.Count() == 1);
            }
        }
    }
}
