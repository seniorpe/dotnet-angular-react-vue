using System.Threading.Tasks;
using Senior.Boilerplate.Models.TokenAuth;
using Senior.Boilerplate.Web.Controllers;
using Shouldly;
using Xunit;

namespace Senior.Boilerplate.Web.Tests.Controllers
{
    public class HomeController_Tests: BoilerplateWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}