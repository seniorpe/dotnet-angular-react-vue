using Abp.Application.Services;
using Senior.Boilerplate.MultiTenancy.Dto;

namespace Senior.Boilerplate.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

