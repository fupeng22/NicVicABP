using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NicVicABP.MultiTenancy.Dto;

namespace NicVicABP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
