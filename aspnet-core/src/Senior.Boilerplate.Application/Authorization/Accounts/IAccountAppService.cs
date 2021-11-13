using System.Threading.Tasks;
using Abp.Application.Services;
using Senior.Boilerplate.Authorization.Accounts.Dto;

namespace Senior.Boilerplate.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
