using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ScotchMe.MultiTenancy.Dto;

namespace ScotchMe.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
