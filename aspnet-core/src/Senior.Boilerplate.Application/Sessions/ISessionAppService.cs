using System.Threading.Tasks;
using Abp.Application.Services;
using Senior.Boilerplate.Sessions.Dto;

namespace Senior.Boilerplate.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
