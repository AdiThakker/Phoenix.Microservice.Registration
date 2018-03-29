using Microsoft.ServiceFabric.Services.Remoting.Client;
using Phoenix.Manager.Registration.Interface;
using System;

namespace Phoenix.Microservice.TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Test_NewUserRegistration();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        private static async void Test_NewUserRegistration()
        {
            Uri uri = new Uri("fabric:/Phoenix.Microservice.Registration/Phoenix.Manager.Registration.Service");
            IRegistrationManager registrationProxy = ServiceProxy.Create<IRegistrationManager>(uri);
            var user = await registrationProxy.CreateNewUser(Guid.NewGuid(), "Sylvester", "Stallone");
            Console.WriteLine($"New user: {user.UserObjectId} {user.FirstName} {user.LastName}");
        }
    }
}
