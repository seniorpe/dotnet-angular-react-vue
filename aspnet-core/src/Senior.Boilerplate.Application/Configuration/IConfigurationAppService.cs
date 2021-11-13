using System.Threading.Tasks;
using Senior.Boilerplate.Configuration.Dto;

namespace Senior.Boilerplate.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
