using Abp.Application.Services;
using Abp.Application.Services.Dto;
using lso.MultiTenancy.Dto;

namespace lso.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
