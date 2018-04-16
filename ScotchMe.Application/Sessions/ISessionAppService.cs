using System.Threading.Tasks;
using Abp.Application.Services;
using ScotchMe.Sessions.Dto;

namespace ScotchMe.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
