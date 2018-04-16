using System.Threading.Tasks;
using Abp.Application.Services;
using ScotchMe.Authorization.Accounts.Dto;

namespace ScotchMe.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
